/*
 MIT License

Copyright (c) 2020 PRASHANTH KUMAR

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */

/*
 * -- IS FRONT END INTERFACE FOR MAIL SERVICE.
 * BACK-END FUNCTIONALITY AND OTHER FEATURE ARE DEFINED IN THERE 
 * RESPECTIVE CLASS FUNCTION.
 * ref: 'MailProcess' class
 *
 
 */
using System;
using System.Windows.Forms;

namespace ServerPlus
{
    public partial class MailServer : Form
    {
        int count = 3; 
        public MailServer()
        {
            InitializeComponent();
        }

        private void MailServer_Load(object sender, EventArgs e)
        {
            // Starts the timer.
            RequestCalculation.Start();
        }

        /*
         * --A Window form framework Timer
            Defined to constantly update, the interface items.
            such as request labels.
        */
        private void RequestCalculation_Tick(object sender, EventArgs e)
        {
            // A simple Function to animate the 'Listening' Label
            if(count >= 0)
            {
                ListenLabel.Text += ".";
                count--;
            }
            else
            {
                count = 3;
                ListenLabel.Text = "Listening";
            }
            /* Utility class: contains the variable that contains the 
              corresponding requests, value.
            */
            MailProcessed.Text = Utility.Mail().ToString();
            MailFailed.Text = Utility.MailFail().ToString();
            MailQueue.Text = Utility.MailQueue().ToString();
        }
    }
}
