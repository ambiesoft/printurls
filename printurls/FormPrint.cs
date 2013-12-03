using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace printurls
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
            Program.commonwb(wbPrint);
            wbPrint.StatusTextChanged += new EventHandler(wbPrint_StatusTextChanged);
        }
        private void wbPrint_StatusTextChanged(object sender, EventArgs e)
        {
            slBrowser.Text = wbPrint.StatusText;
        }
        internal List<string> _urls = null;
        
        private void FormPrint_Load(object sender, EventArgs e)
        {
            progMain.Maximum = _urls.Count;
            basicTimer.Enabled = true;
        }

        //void wait(int second)
        //{
        //    int start = Environment.TickCount;
        //    while (((Environment.TickCount - start) / 1000) < second)
        //    {
        //        Application.DoEvents();
        //        if (_closing)
        //            break;
        //    }
        //}

        //private void doit()
        //{
        //    foreach (string url in _urls)
        //    {
        //        if (_closing)
        //            break;

        //        while (chkPause.Checked)
        //        {
        //            wait(5);
        //        }
        //        wbPrint.Navigate(url);

        //        while (wbPrint.ReadyState != WebBrowserReadyState.Complete)
        //        {
        //            Application.DoEvents();
        //        }
        //        if (_closing)
        //            break;
        //        wbPrint.Print();

        //        wait(decimal.ToInt32(udWait.Value));
        //        while (wbPrint.ReadyState != WebBrowserReadyState.Complete)
        //        {
        //            Application.DoEvents();
        //        }
        //    }
        //}
        //bool _closing = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            //_closing = true;
            Close();
        }

        void waitBrowser()
        {
            while (wbPrint.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }
        }

        int _curIndex = 0;
        static bool inprocess = false;
        int _waitCounter=0;

        private void basicTimer_Tick(object sender, EventArgs e)
        {

            if (_curIndex >= _urls.Count)
                return;

            if (inprocess)
                return;

            if (_waitCounter >= 0)
            {
                --_waitCounter;
                slStatus.Text = _waitCounter.ToString();
                return;
            }


            if (chkPause.Checked)
            {
                slStatus.Text = "Paused";
                return;
            }

            slStatus.Text = "";

            inprocess = true;
            progMain.Value = _curIndex;
            try
            {
                string url = _urls[_curIndex];

                wbPrint.Navigate(url);

                waitBrowser();

                if (chkPause.Checked)
                    return;

                slStatus.Text = "Printing...";
                wbPrint.Print();
                slStatus.Text = "";

                waitBrowser();

                _waitCounter = (decimal.ToInt32(udWait.Value));
                ++_curIndex;
                if (_curIndex >= _urls.Count)
                {
                    MessageBox.Show("done!");
                    Close();
                    return;
                }
                this.Text = _curIndex.ToString() + "/" + _urls.Count.ToString();
                progMain.Value = _curIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inprocess = false;
            }
        }
    }
}
