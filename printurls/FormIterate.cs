﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mshtml;

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

        private void FormIterate_Load(object sender, EventArgs e)
        {
            // BeginInvoke(new dele(doit));
            wbBase.Navigate(_url);
        }
        
        void ExtractLinks(bool bOnlySelected)
        {
            while (wbBase.ReadyState != WebBrowserReadyState.Complete)
            {
                Application.DoEvents();
            }

            if (bOnlySelected)
            {
                try
                {
                    IHTMLDocument2 htmlDocument = wbBase.Document.DomDocument as IHTMLDocument2;
                    if (htmlDocument == null)
                        throw new Exception("No htmlDocument");

                    IHTMLSelectionObject currentSelection = htmlDocument.selection;
                    if (currentSelection == null)
                        throw new Exception("No Selection");

                    //if (currentSelection.type == "Text")
                    //    throw new Exception("No Links in the selection");

                    //if(currentSelection.type!="Control")
                    //    throw new Exception("No Links in the selection");


                    IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;
                    if(range==null)
                        throw new Exception("No Links in the selection");

                    string html = range.htmlText;
                    if(string.IsNullOrEmpty(html))
                        throw new Exception("No Links in the selection");

                    Uri baseurl = wbBase.Url;
                    HtmlAgilityPack.HtmlDocument adoc = new HtmlAgilityPack.HtmlDocument();
                    adoc.LoadHtml(html);
                    foreach ( HtmlAgilityPack.HtmlNode link in adoc.DocumentNode.SelectNodes("//a[@href]"))
                    {
                        Uri u = new Uri(baseurl, link.Attributes["href"].Value.ToString());
                        listUrls.Items.Add(u.AbsoluteUri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
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

        private void tsbExtractAllLinks_Click(object sender, EventArgs e)
        {
            ExtractLinks(false);
        }

        private void tsbExtractSelectedLinks_Click(object sender, EventArgs e)
        {
            ExtractLinks(true);
        }




   
    }
}
