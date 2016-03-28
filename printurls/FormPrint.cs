using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Printing;
using System.Drawing.Printing;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            //_closing = true;

            Close();
        }

        private bool _forcenext;
        void waitBrowser()
        {
            btnPrintAndGoNext.Enabled = true;
            int start = Environment.TickCount;
            bool failed = false;
            while (wbPrint.ReadyState < WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
                if (_forcenext)
                {
                    _forcenext = false;
                    break;
                }
                if ((Environment.TickCount - start) > 30 * 1000)
                {
                    failed = true;
                    break;
                }
            }

            if (failed)
            {
                while (wbPrint.ReadyState < WebBrowserReadyState.Interactive)
                {
                    Application.DoEvents();
                    if (_forcenext)
                    {
                        _forcenext = false;
                        break;
                    }
                }
            }
            btnPrintAndGoNext.Enabled = false;
        }


        PrintQueue pq_;
        private void initPrinter()
        {
            //if (pq_ != null)
            //    return;

            LocalPrintServer lps = new LocalPrintServer();
            PrintQueueCollection queueCollection = lps.GetPrintQueues();

            
            PrinterSettings settings = new PrinterSettings();
            if (settings == null)
                return;

            string defprinter = settings.PrinterName;

            foreach (PrintQueue pq in queueCollection)
            {
                if (pq.FullName == defprinter)
                {
                    pq_ = pq;
                    return;
                }
            }
        }
        
        private int GetNumberOfPrintJobs()
        {
            initPrinter();
            return pq_ == null ? 0 : pq_.NumberOfJobs;
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

            if (_waitCounter > 0)
            {
                slStatus.Text = _waitCounter.ToString();
                --_waitCounter;
                
                return;
            }

            if (GetNumberOfPrintJobs() != 0)
            {
                slStatus.Text = Properties.Resources.PRINTERISBUSY;
                return;
            }

            if (chkPause.Checked)
            {
                slStatus.Text = Properties.Resources.PAUSED;
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

                slStatus.Text = Properties.Resources.PRINTING;
                wbPrint.Print();
                slStatus.Text = "";

                waitBrowser();

                _waitCounter = (decimal.ToInt32(udWait.Value));
                ++_curIndex;
                this.Text = _curIndex.ToString() + "/" + _urls.Count.ToString();
                progMain.Value = _curIndex;

                if (_curIndex >= _urls.Count)
                {
                    MessageBox.Show(this, 
                        Properties.Resources.DONE,
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    return;
                }
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

        private void btnPrintAndGoNext_Click(object sender, EventArgs e)
        {
            _forcenext = true;
        }

        private void wbPrint_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtUrl.Text = wbPrint.Url.AbsoluteUri;
        }

        private void FormPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes != MessageBox.Show(Properties.Resources.AreYouSureToQuit,
                Application.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
                return;
            }
        }
    }
}
