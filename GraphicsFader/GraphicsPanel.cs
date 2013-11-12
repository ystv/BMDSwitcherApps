﻿/* -LICENSE-START-
** Copyright (c) 2011 Blackmagic Design
**
** Permission is hereby granted, free of charge, to any person or organization
** obtaining a copy of the software and accompanying documentation covered by
** this license (the "Software") to use, reproduce, display, distribute,
** execute, and transmit the Software, and to prepare derivative works of the
** Software, and to permit third-parties to whom the Software is furnished to
** do so, all subject to the following:
** 
** The copyright notices in the Software and this entire statement, including
** the above license grant, this restriction and the following disclaimer,
** must be included in all copies of the Software, in whole or in part, and
** all derivative works of the Software, unless such copies or derivative
** works are solely in the form of machine-executable object code generated by
** a source language processor.
** 
** THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
** IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
** FITNESS FOR A PARTICULAR PURPOSE, TITLE AND NON-INFRINGEMENT. IN NO EVENT
** SHALL THE COPYRIGHT HOLDERS OR ANYONE DISTRIBUTING THE SOFTWARE BE LIABLE
** FOR ANY DAMAGES OR OTHER LIABILITY, WHETHER IN CONTRACT, TORT OR OTHERWISE,
** ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
** DEALINGS IN THE SOFTWARE.
** -LICENSE-END-
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

using BMDSwitcherAPI;

namespace SwitcherPanelCSharp
{
    public partial class SwitcherPanel : Form
    {
        private IBMDSwitcherDiscovery m_switcherDiscovery;
        private IBMDSwitcher m_switcher;
        private IBMDSwitcherDownstreamKey m_dsk1;

        private SwitcherMonitor m_switcherMonitor;
        private DSKMonitor m_dskMonitor;

        private List<InputMonitor> m_inputMonitors = new List<InputMonitor>();

        public SwitcherPanel()
        {
            InitializeComponent();

            m_switcherMonitor = new SwitcherMonitor();
            // note: this invoke pattern ensures our callback is called in the main thread. We are making double
            // use of lambda expressions here to achieve this.
            // Essentially, the events will arrive at the callback class (implemented by our monitor classes)
            // on a separate thread. We must marshell these to the main thread, and we're doing this by calling
            // invoke on the Windows Forms object. The lambda expression is just a simplification.
            m_switcherMonitor.SwitcherDisconnected += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => SwitcherDisconnected())));

            m_dskMonitor = new DSKMonitor();
            m_dskMonitor.OnAirChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => UpdateFadeButtonState())));
            m_dskMonitor.TransitionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => UpdateFadeButtonState())));
            m_dskMonitor.RateChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => UpdateTransitionRate())));

            m_switcherDiscovery = new CBMDSwitcherDiscovery();
            if (m_switcherDiscovery == null)
            {
                MessageBox.Show("Could not create Switcher Discovery Instance.\nATEM Switcher Software may not be installed.", "Error");
                Environment.Exit(1);
            }
            
            SwitcherDisconnected();		// start with switcher disconnected
        }

        private void SwitcherConnected()
        {
            buttonConnect.Enabled = false;

            // Get the switcher name:
            string switcherName;
            m_switcher.GetProductName(out switcherName);
            textBoxSwitcherName.Text = switcherName;

            // Install SwitcherMonitor callbacks:
            m_switcher.AddCallback(m_switcherMonitor);

            // Get DSK 1
            m_dsk1 = null;
            IBMDSwitcherDownstreamKeyIterator meDSKIterator;
            SwitcherAPIHelper.CreateIterator(m_switcher, out meDSKIterator);

            if (meDSKIterator != null)
            {
                meDSKIterator.Next(out m_dsk1);
            }

            if (m_dsk1 == null)
            {
                MessageBox.Show("Unable to get first downstream keyer", "Error");
                return;
            }

            // Install DSKMonitor callbacks
            m_dsk1.AddCallback(m_dskMonitor);

            // Enable buttons and stuff
            btnFade.Enabled = true;
            tsStatus.Text = "Connected!";
            btnSet.Enabled = true;

            UpdateFadeButtonState();
            UpdateTransitionRate();
        }

        private void SwitcherDisconnected()
        {
            buttonConnect.Enabled = true;
            textBoxSwitcherName.Text = "";

            btnFade.Enabled = false;
            tsStatus.Text = "Not Connected";
            btnSet.Enabled = false;

            if (m_dsk1 != null)
            {
                // Remove callback
                m_dsk1.RemoveCallback(m_dskMonitor);

                // Release reference
                m_dsk1 = null;
            }

            if (m_switcher != null)
            {
                // Remove callback:
                m_switcher.RemoveCallback(m_switcherMonitor);

                // release reference:
                m_switcher = null;
            }
        }

        private void UpdateFadeButtonState()
        {
            int onair;
            int autoactive;
            int transactive;

            try
            {
                m_dsk1.GetOnAir(out onair);
                m_dsk1.IsAutoTransitioning(out autoactive);
                m_dsk1.IsTransitioning(out transactive);

                if (1 == autoactive || 1 == transactive)
                {
                    btnFade.Text = "Fading";
                    tsStatus.Text = "Transitioning";
                    btnFade.BackColor = Color.Orange;
                }
                else if (0 == onair)
                {
                    btnFade.Text = "Fade In";
                    tsStatus.Text = "Off Air";
                    btnFade.BackColor = Color.Green;
                }
                else
                {
                    btnFade.Text = "Fade Out";
                    tsStatus.Text = "On Air";
                    btnFade.BackColor = Color.Red;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void UpdateTransitionRate()
        {
            try
            {
                uint newrate;
                m_dsk1.GetRate(out newrate);

                float newtime = (float)(newrate / GraphicsFader.Properties.Settings.Default.Framerate);
                txtFadeTime.Text = newtime.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting new rate. Error: " + ex.Message);
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _BMDSwitcherConnectToFailure failReason = 0;
            string address = textBoxIP.Text;

            try
            {
                // Note that ConnectTo() can take several seconds to return, both for success or failure,
                // depending upon hostname resolution and network response times, so it may be best to
                // do this in a separate thread to prevent the main GUI thread blocking.
                m_switcherDiscovery.ConnectTo(address, out m_switcher, out failReason);
            }
            catch (COMException)
            {
                // An exception will be thrown if ConnectTo fails. For more information, see failReason.
                switch (failReason)
                {
                    case _BMDSwitcherConnectToFailure.bmdSwitcherConnectToFailureNoResponse:
                        MessageBox.Show("No response from Switcher", "Error");
                        break;
                    case _BMDSwitcherConnectToFailure.bmdSwitcherConnectToFailureIncompatibleFirmware:
                        MessageBox.Show("Switcher has incompatible firmware", "Error");
                        break;
                    default:
                        MessageBox.Show("Connection failed for unknown reason", "Error");
                        break;
                }
                return;
            }

            SwitcherConnected();
        }


        /// <summary>
        /// Used for putting other object types into combo boxes.
        /// </summary>
        struct StringObjectPair<T>
        {
            public string name;
            public T value;

            public StringObjectPair(string name, T value)
            {
                this.name = name;
                this.value = value;
            }

            public override string ToString()
            {
                return name;
            }
        }

        private void btnFade_Click(object sender, EventArgs e)
        {
            try
            {
                m_dsk1.PerformAutoTransition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to perform fade. Error: " + ex.Message);
            }
        }

        private void textFadeTime_Validate(object sender, EventArgs e)
        {
            float newtime;
            if (float.TryParse(txtFadeTime.Text, out newtime) && newtime >= 0 &&
                newtime < (255 / GraphicsFader.Properties.Settings.Default.Framerate))
            {
                txtFadeTime.BackColor = Color.White;
                btnSet.Enabled = true;
            }
            else
            {
                txtFadeTime.BackColor = Color.PaleVioletRed;
                btnSet.Enabled = false;
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            float newtime;
            if (float.TryParse(txtFadeTime.Text, out newtime) && newtime >= 0 &&
                newtime < (255 / GraphicsFader.Properties.Settings.Default.Framerate))
            {
                txtFadeTime.BackColor = Color.White;
                uint newframes = (uint)(newtime * GraphicsFader.Properties.Settings.Default.Framerate);
                m_dsk1.SetRate(newframes);
            }
            else
            {
                txtFadeTime.BackColor = Color.PaleVioletRed;
            }
        }
    }
}