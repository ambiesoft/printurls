using Ambiesoft;
using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;

namespace printurls
{
    public partial class DialogSettings : Form
    {
        private static readonly string APP_OPTION = "OPTION";
        private static readonly string KEY_IS_USE_WAV_AFTER_FINISHED = "IsUseWavAfterFinished";
        private static readonly string KEY_WAV_FILE = "WavFile";

        public static bool IsUseWavAfterFinished { get; set; }
        // Public static property to store the WAV file path
        public static string WavFile { get; set; } = string.Empty;
        
        private static string IniPath
        {
            get
            {
                return Path.Combine(
                    Path.GetDirectoryName(Application.ExecutablePath),
                    Path.GetFileNameWithoutExtension(Application.ExecutablePath) + ".ini");
            }
        }
        public DialogSettings()
        {
            InitializeComponent();
        }

        static DialogSettings()
        {
            bool boolVal;
            string strVal;

            HashIni ini = Profile.ReadAll(IniPath);
            Profile.GetBool(APP_OPTION, KEY_IS_USE_WAV_AFTER_FINISHED, false, out boolVal, ini);
            IsUseWavAfterFinished = boolVal;

            Profile.GetString(APP_OPTION, KEY_WAV_FILE, string.Empty, out strVal, ini);
            WavFile = strVal;
        }
        internal static void DoShowDialog(Control parent)
        {
            using (var dlg = new DialogSettings())
            {
                dlg.chkPlayAfterFinished.Checked = IsUseWavAfterFinished;
                dlg.txtWavFile.Text = WavFile;

                if (dlg.ShowDialog(parent) == DialogResult.OK)
                {
                    IsUseWavAfterFinished = dlg.chkPlayAfterFinished.Checked;
                    WavFile = dlg.txtWavFile.Text;

                    Profile.WriteBool(
                        APP_OPTION,
                        KEY_IS_USE_WAV_AFTER_FINISHED,
                        IsUseWavAfterFinished,
                        IniPath);
                    Profile.WriteString(
                        APP_OPTION,
                        KEY_WAV_FILE,
                        WavFile,
                        IniPath);
                }
            }
        }
        private void btnNavigateWav_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Select WAV file";
                dlg.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
                dlg.FilterIndex = 1;
                dlg.RestoreDirectory = true;
                dlg.Multiselect = false;

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtWavFile.Text = dlg.FileName;
                }
            }
        }
    }
}
