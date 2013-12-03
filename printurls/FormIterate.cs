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
            wbBase.StatusTextChanged += new EventHandler(wbBase_StatusTextChanged);
        }
        private void wbBase_StatusTextChanged(object sender, EventArgs e)
        {
            slMain.Text = wbBase.StatusText;
        }
        internal string _url;

        delegate void dele();
        
        private void FormIterate_Load(object sender, EventArgs e)
        {
            BeginInvoke(new dele(doit));
        }
        void doit()
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

        string getUnhashUrl(Uri u)
        {
            string f = u.Fragment;
            if (string.IsNullOrEmpty(f))
                return u.AbsoluteUri;

            string a = u.AbsoluteUri;
            int i = a.LastIndexOf(f);
            if (i < 0)
                return a;

            string ret = a.Substring(0, i);
            return ret;
        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            List<string> unique = new List<string>();
            List<string> unique2add = new List<string>();
            foreach (ListViewItem item in listUrls.Items)
            {
                Uri u;
                string unhashurl;
                try
                {
                    u = new Uri(item.Text);
                    unhashurl = getUnhashUrl(u);
                }
                catch (Exception) 
                {
                    continue;
                }


                if (unique.Contains(unhashurl))
                    continue;

                unique.Add(unhashurl);
                unique2add.Add(item.Text);
            }

            listUrls.Items.Clear();

            foreach (string url in unique2add)
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
