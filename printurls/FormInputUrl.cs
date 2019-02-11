﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ambiesoft;
using System.Reflection;

namespace printurls
{
    public partial class FormInputUrl : Form
    {
        public FormInputUrl(string[] args)
        {
            InitializeComponent();

            StringBuilder sbEnterUrls = new StringBuilder();
            try
            {
                for(int i=0 ; i < args.Length; ++i)
                {
                    string arg = args[i];
                    if (arg == "-page")
                    {
                        ++i;
                        txtPageUrl.Text = args[i];
                    }
                    else
                    {
                        sbEnterUrls.AppendLine(arg);
                    }
                }
            }
            catch (Exception) { }
            txtEnterURLs.Text = sbEnterUrls.ToString();   
        }

        private void FormInputUrl_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPageUrl.Text))
            {
                try
                {
                    txtPageUrl.Text = Clipboard.GetText();
                }
                catch (Exception) { }
            }

            radioOpenUrl.Checked = true;
        }

        private void OnAfterRadioChange()
        {
            txtPageUrl.Enabled = radioOpenUrl.Checked;
            txtEnterURLs.Enabled = !radioOpenUrl.Checked;
            btnExpand.Enabled = !radioOpenUrl.Checked;
        }

        private void radioOpenUrl_CheckedChanged(object sender, EventArgs e)
        {
            OnAfterRadioChange();
        }

        private void radioEnterURLs_CheckedChanged(object sender, EventArgs e)
        {
            OnAfterRadioChange();
        }


        private string[] ExpandURL(string url)
        {
            string[] defret = new string[1] {url};

            if(string.IsNullOrEmpty(url))
                return defret;

            int start = url.IndexOf('[');
            if( 0 > start )
                return defret;

            int end = url.IndexOf(']', start+1);
            if ( 0 > end )
                return defret;

            string betw = url.Substring(start+1,end-start-1);
            if(string.IsNullOrEmpty(betw))
                return defret;

            string[] snen = betw.Split('-');
            if(snen.Length !=2)
                return defret;

            int nStart;
            int kStart = snen[0].Length;
            if (!int.TryParse(snen[0], out nStart))
                return defret;

            int nEnd;
            int kEnd = snen[1].Length;
            if (!int.TryParse(snen[1], out nEnd))
                return defret;

            if (nStart > nEnd)
                return defret;

            List<string> result = new List<string>();
            for (int i = nStart; i <= nEnd; ++i)
            {
                string ni = i.ToString();
                while (ni.Length < kStart)
                    ni = "0" + ni;

                string dekita = url.Substring(0, start);
                dekita += ni;
                dekita += url.Substring(end+1);

                result.Add(dekita);
            }
            return result.ToArray();
        }



        private void btnExpand_Click(object sender, EventArgs e)
        {
            string[] urls = txtEnterURLs.Lines;
            StringBuilder sb = new StringBuilder();
            foreach (string line in urls)
            {
                string[] rets = ExpandURL(line);
                foreach (string t in rets)
                {
                    if(!string.IsNullOrEmpty(t))
                        sb.AppendLine(t);
                }
            }
            txtEnterURLs.Text = sb.ToString();
        }


        public bool IsResultOpenURL;
        public string[] ResultURLs;
        private void btnStart_Click(object sender, EventArgs e)
        {
            IsResultOpenURL = radioOpenUrl.Checked;
            if (IsResultOpenURL)
                return;


            ResultURLs = txtEnterURLs.Lines;
            foreach (string u in ResultURLs)
            {
                if (u.IndexOf('[') >= 0 && u.IndexOf(']') >= 0)
                {
                    if (DialogResult.Yes != CppUtils.CenteredMessageBox(this,
                        Properties.Resources.URL_INCLUDES_BLANCKET_CONTINUE,
                        Application.ProductName,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2))
                    {
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Application.ProductName);
            sb.Append("Version");
            sb.Append(" ");
            sb.Append(AmbLib.getAssemblyVersion(Assembly.GetExecutingAssembly(),3));
            sb.AppendLine();
            sb.Append("copyright 2017 ");
            sb.Append("Ambiesoft");

            CppUtils.CenteredMessageBox(this,
                sb.ToString(),
                Application.ProductName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                
        }

    }
}
