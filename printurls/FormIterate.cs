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
    public partial class FormIterate : Form
    {
        public FormIterate()
        {
            InitializeComponent();
            Program.commonwb(wbBase);
        }

        internal string _url;


        private void FormIterate_Load(object sender, EventArgs e)
        {
            wbBase.Navigate(_url);

            while (wbBase.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }


            HtmlDocument doc = wbBase.Document;
            Dictionary<string, int> tagcounter = new Dictionary<string, int>();
            List<string> urls = new List<string>();
            foreach (HtmlElement elm in doc.All)
            {
                if (elm.TagName == "a" || elm.TagName == "A")
                {
                    string url = elm.GetAttribute("href");
                    urls.Add(url);
                    listUrls.Items.Add(url);
                }
            }

 
        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            List<string> unique = new List<string>();
            foreach (ListViewItem item in listUrls.Items)
            {
                Uri u;
                try
                {
                    u = new Uri(item.Text);
                }
                catch (Exception) 
                {
                    continue;
                }

                string nonhash = u.AbsoluteUri;
                if (unique.Contains(nonhash))
                    continue;

                unique.Add(item.Text);
            }

            listUrls.Items.Clear();

            foreach (string url in unique)
                listUrls.Items.Add(url);
                
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listUrls.SelectedItems)
            {
                listUrls.Items.Remove(item);
            }
        }

        internal List<string> _retresult;
        private void btnPrintAll_Click(object sender, EventArgs e)
        {
            _retresult = new List<string>();
            foreach (ListViewItem item in listUrls.Items)
            {
                _retresult.Add(item.Text);
            }
        }
   
    }
}
