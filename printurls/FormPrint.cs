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
        }

        internal List<string> _urls = null;
        private void FormPrint_Load(object sender, EventArgs e)
        {
            BeginInvoke(new dele(doit));
        }

        void wait(int second)
        {
            int start = Environment.TickCount;
            while (((Environment.TickCount - start) / 1000) < second)
            {
                Application.DoEvents();
                if (_closing)
                    break;
            }
        }

        delegate void dele();
        private void doit()
        {
            foreach (string url in _urls)
            {
                if (_closing)
                    break;

                while (chkPause.Checked)
                {
                    wait(5);
                }
                wbPrint.Navigate(url);

                while (wbPrint.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
                if (_closing)
                    break;
                wbPrint.Print();

                wait(decimal.ToInt32(udWait.Value));
                while (wbPrint.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
            }
        }
        bool _closing = false;
        private void btnClose_Click(object sender, EventArgs e)
        {
            _closing = true;
            Close();
        }
    }
}
