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
        internal static void showerror(string err)
        {
            MessageBox.Show(

                err,
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        static bool setBrowserEmulationMode(int ieversion)
        {
            Microsoft.Win32.RegistryKey regKey = null;
            try
            {
                string FEATURE_BROWSER_EMULATION = "Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION";
                regKey = (Microsoft.Win32.Registry.CurrentUser.CreateSubKey(FEATURE_BROWSER_EMULATION));
                if (regKey == null)
                    return false;

                string exename = System.IO.Path.GetFileName(System.Windows.Forms.Application.ExecutablePath);

                if (ieversion == -1)
                {
                    regKey.DeleteValue(exename);
                }
                else
                {
                    int v = ieversion * 1000;
                    regKey.SetValue(exename, v, Microsoft.Win32.RegistryValueKind.DWord);
                }
                return true;
            }
            catch (Exception) { }
            finally
            {
                if (regKey != null)
                    regKey.Close();
            }
            return false;
        }

        static int GetIEVersion()
        {
            Microsoft.Win32.RegistryKey regKey = null;
            int ret = -1;
            try
            {
                string KEY_IE_VERSION = "SOFTWARE\\Microsoft\\Internet Explorer";


                regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KEY_IE_VERSION, false);
                if (regKey == null)
                    return -1;

                string version = regKey.GetValue("Version").ToString();
                string[] vs = version.Split('.');
                int iversion = System.Int32.Parse(vs[0]);
                if (iversion < 9)
                    return iversion;

                ret = iversion;

                string srcversion = regKey.GetValue("svcVersion").ToString();
                string[] svs = srcversion.Split('.');
                int isversion = System.Int32.Parse(svs[0]);

                return isversion;
            }
            catch (System.Exception) { }
            finally
            {
                if (regKey != null)
                    regKey.Close();
            }
            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // Ambiesoft.CppUtils.AmbSetProcessDPIAware();

            try
            {
                string lang = string.Empty;
                for (int i = 0; i < args.Length; ++i)
                {
                    string arg = args[i];
                    if (arg == "-lang")
                    {
                        lang = args[i + 1];
                        if (string.Compare(lang, "ja", true) == 0 ||
                            string.Compare(lang, "jp", true) == 0 ||
                            string.Compare(lang, "jpn", true) == 0 ||
                            string.Compare(lang, "japanese", true) == 0)
                        {
                            lang = "ja-JP";
                        }
                        break;
                    }
                }

                if (!string.IsNullOrEmpty(lang))
                {
                    System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ja-JP");
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                    System.Threading.Thread.CurrentThread.CurrentUICulture = ci;
                }
            }
            catch (Exception ex)
            {
                Ambiesoft.CppUtils.Alert(ex);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            setBrowserEmulationMode(GetIEVersion());

            FormInputUrl inputdlg = new FormInputUrl(args);
            if (DialogResult.OK != inputdlg.ShowDialog())
                return;

            List<string> urls;
            if (inputdlg.IsResultOpenURL)
            {
                string url = inputdlg.txtPageUrl.Text;
                if (string.IsNullOrEmpty(url))
                {
                    // showerror(printurls.Properties.Resources.NOURL);
                    url = "about:blank";
                }

                FormIterate itrdlg = new FormIterate();
                itrdlg._url = url;
                if (DialogResult.OK != itrdlg.ShowDialog())
                    return;

                urls = itrdlg._retresult;
            }
            else
            {
                urls = new List<string>(inputdlg.ResultURLs);
            }

            if (urls == null || urls.Count == 0)
            {
                showerror(printurls.Properties.Resources.NOURL);
                return;
            }


            FormPrint pntdlg = new FormPrint();
            pntdlg._urls = urls;
            pntdlg.ShowDialog();
        }
    }
}
