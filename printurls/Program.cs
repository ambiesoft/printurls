using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace printurls
{
    static class Program
    {
        public static void commonwb(WebBrowser wb)
        {
            wb.ScriptErrorsSuppressed = true;

        }
        static void showerror(string err)
        {
            MessageBox.Show(err,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormInputUrl inputdlg = new FormInputUrl();
            if (DialogResult.OK != inputdlg.ShowDialog())
                return;

            string url = inputdlg.txtUrl.Text;
            if (string.IsNullOrEmpty(url))
            {
                showerror("no url");
                return;
            }

            
            
            FormIterate itrdlg = new FormIterate();
            itrdlg._url = url;
            if (DialogResult.OK != itrdlg.ShowDialog())
                return;

            if (itrdlg._retresult.Count == 0)
            {
                showerror("no urls");
                return;
            }

            FormPrint pntdlg = new FormPrint();
            pntdlg._urls = itrdlg._retresult;
            pntdlg.ShowDialog();
        }
    }
}
