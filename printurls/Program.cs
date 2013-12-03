using System;
using System.Collections.Generic;
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
	
        static bool setBrowserEmulationMode()
	    {
		    Microsoft.Win32.RegistryKey regKey = null;
		    try
		    {
			    string FEATURE_BROWSER_EMULATION = "Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION";
			    regKey = (Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION));
			    if(regKey==null)
				    return false;

                string exename = System.IO.Path.GetFileName(System.Windows.Forms.Application.ExecutablePath);
                regKey.SetValue(exename, 0, Microsoft.Win32.RegistryValueKind.DWord);

                return true;
		    }
		    catch(Exception){}
		    finally
		    {
			    if(regKey != null)
				    regKey.Close();
		    }
		    return false;
	    }
        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            setBrowserEmulationMode();

            FormInputUrl inputdlg = new FormInputUrl();
            if (DialogResult.OK != inputdlg.ShowDialog())
                return;

            string url = inputdlg.txtUrl.Text;
            if (string.IsNullOrEmpty(url))
            {
                showerror(printurls.Properties.Resources.NOURL);
                return;
            }

            
            
            FormIterate itrdlg = new FormIterate();
            itrdlg._url = url;
            if (DialogResult.OK != itrdlg.ShowDialog())
                return;

            if (itrdlg._retresult.Count == 0)
            {
                showerror(printurls.Properties.Resources.NOURL);
                return;
            }

            FormPrint pntdlg = new FormPrint();
            pntdlg._urls = itrdlg._retresult;
            pntdlg.ShowDialog();
        }
    }
}
