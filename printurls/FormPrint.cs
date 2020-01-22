using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Printing;
using System.Drawing.Printing;
using Ambiesoft;
using System.IO;

namespace printurls
{
    public partial class FormPrint : Form
    {
        readonly string SECTION_OPTION = "options";
        readonly string KEY_WAIT_COUNT = "waitcount";

        private bool _forcenext;
        PrintQueue _pq;
        int _curIndex = 0;
        static bool _inprocess = false;
        int _waitCounter = 0;
        internal List<string> _urls = null;

        string IniFile
        {
            get
            {
                string ret = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                    Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini");
                return ret;
            }
        }
        public FormPrint()
        {
            InitializeComponent();

            HashIni ini = Profile.ReadAll(IniFile);
            int intval;
            if (Profile.GetInt(SECTION_OPTION, KEY_WAIT_COUNT, -1, out intval, ini) && intval > 0)
            {
                udWait.Value = intval;
            }
            this.Size = new Size(this.Size.Width, (int)(this.Size.Height * 1.5));
            Program.commonwb(wbPrint);
            wbPrint.StatusTextChanged += new EventHandler(wbPrint_StatusTextChanged);
        }
        private void wbPrint_StatusTextChanged(object sender, EventArgs e)
        {
            slBrowser.Text = wbPrint.StatusText;
        }
        


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

        WebBrowserReadyState CurrentBrowserState
        {
            get
            {
                try
                {
                    return wbPrint.ReadyState;
                }
                catch (Exception ex)
                {
                    slStatus.Text = ex.Message;
                }
                return WebBrowserReadyState.Uninitialized;
            }
        }
        
        void waitBrowser()
        {
            btnPrintAndGoNext.Enabled = true;
            int start = Environment.TickCount;
            bool failed = false;

            while (CurrentBrowserState < WebBrowserReadyState.Complete)
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

        void waitSimple(int sec)
        {
            int start = Environment.TickCount;
            while (true)
            {
                Application.DoEvents();
                if ((Environment.TickCount - start) > (sec * 1000))
                {
                    break;
                }
            }
        }

        
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
                    _pq = pq;
                    return;
                }
            }
        }

        private int GetNumberOfPrintJobs()
        {
            initPrinter();
            return _pq == null ? 0 : _pq.NumberOfJobs;
        }


        void UpdateTitle()
        {
            this.Text = string.Format("{0}% {1} - {2}",
                AmbLib.GetRatioString(_curIndex, _urls.Count),
                _curIndex.ToString() + "/" + _urls.Count.ToString(),
                Application.ProductName);
        }
        private void DoTimerStaff()
        {
            progMain.Value = _curIndex;
            //try
            {
                string url = _urls[_curIndex];

                wbPrint.Navigate(url);

                waitBrowser();

                if (chkPause.Checked)
                    return;

                slStatus.Text = Properties.Resources.PRINTING;
                waitSimple(decimal.ToInt32(udPrintWait.Value));
                wbPrint.Print();
                slStatus.Text = "";

                waitBrowser();

                _waitCounter = (decimal.ToInt32(udWait.Value));
                ++_curIndex;
                UpdateTitle();
                progMain.Value = _curIndex;

                if (_curIndex >= _urls.Count)
                {
                    this.Focus();
                    CppUtils.CenteredMessageBox(this,
                        Properties.Resources.DONE,
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                    return;
                }
            }
            //catch (Exception ex)
            //{
            //    CppUtils.CenteredMessageBox(this, ex.Message);
            //}
            //finally
            {
                //inprocess = false;
            }

        }
        private void basicTimer_Tick(object sender, EventArgs e)
        {
            if (_curIndex >= _urls.Count)
                return;

            if (_inprocess)
                return;

            if (_waitCounter > 0)
            {
                slStatus.Text = Properties.Resources.INTERVAL_WAIT + _waitCounter.ToString();
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

            _inprocess = true;
            DoTimerStaff();
            _inprocess = false;
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
            if (DialogResult.Yes != CppUtils.CenteredMessageBox(this,
                Properties.Resources.AreYouSureToQuit,
                Application.ProductName,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
                return;
            }

            HashIni ini = Profile.ReadAll(IniFile);
            Profile.WriteInt(SECTION_OPTION, KEY_WAIT_COUNT, decimal.ToInt32(udWait.Value), ini);
            if(!Profile.WriteAll(ini,IniFile))
            {
                CppUtils.Alert(Properties.Resources.FAILED_TO_SAVE_INI);
            }
            Environment.Exit(0);
        }
    }
}
