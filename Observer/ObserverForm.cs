﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class ObserverForm : Form
    {
        private ConcreteObserver m_concreteObserver = null;
        private TimeAsSecondSubject m_concreteSubject = null;

        public ObserverForm()
        {
            InitializeComponent();
        }

        private void buttonDoObserve_Click(object sender, EventArgs e)
        {
            if (buttonDoObserve.Text.Contains("Do Observe"))
            {
                m_concreteSubject = new TimeAsSecondSubject();
                m_concreteObserver = new ConcreteObserver("Observe On Trace");

                m_concreteSubject.Attach(m_concreteObserver);
                m_concreteSubject.StartUpdateByMyself();

                watch1_button.Enabled = true;
                buttonDoObserve.Text = "Stop Observe";
            }
            else
            {
                m_concreteSubject.DetachAll();
                m_concreteSubject.StopUpdateByMyself();
                m_concreteSubject = null;
                m_concreteObserver = null;

                watch1_button.Enabled = false;
                buttonDoObserve.Text = "Do Observe";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void watch1_button_Click(object sender, EventArgs e)
        {
            if (watch1_button.Text.Contains("Do Watch"))
            {
                m_concreteSubject.Attach(textBoxTimeAsSecond);

                watch1_button.Text = "Stop Watch";
            }
            else
            {
                m_concreteSubject.Detach(textBoxTimeAsSecond);

                watch1_button.Text = "Do Watch";
            }
        }
    }
}
