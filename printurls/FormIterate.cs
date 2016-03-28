using System;
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
            Application.Idle += new EventHandler(Application_Idle);
        }
        private void wbBase_StatusTextChanged(object sender, EventArgs e)
        {
            slMain.Text = wbBase.StatusText;
        }
        internal string _url;

        private void Application_Idle(Object sender, EventArgs e)
        {
            if (listUrls.Created && !listUrls.IsDisposed)
            {
                slMain.Text = listUrls.Items.Count.ToString();
            }
        }
        private void FormIterate_Load(object sender, EventArgs e)
        {
            // BeginInvoke(new dele(doit));
            wbBase.Navigate(_url);
        }
        
        void ExtractLinks(bool bOnlySelected)
        {
            using (new WaitCursor())
            {
                DateTime start = DateTime.Now;
                while (wbBase.ReadyState < WebBrowserReadyState.Interactive)
                {
                    Application.DoEvents();
                    TimeSpan ts = DateTime.Now.Subtract(start);
                    if (ts.Seconds > 10)
                    {
                        switch (MessageBox.Show(Properties.Resources.CancelCompleteCheck,
                            Application.ProductName,
                            MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Question))
                        {
                            case DialogResult.No:
                                start = DateTime.Now;
                                continue;

                            case DialogResult.Cancel:
                                return;
                        }
                        break;
                    }
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
                        if (range == null)
                            throw new Exception("No Links in the selection");

                        string html = range.htmlText;
                        if (string.IsNullOrEmpty(html))
                            throw new Exception("No Links in the selection");

                        Uri baseurl = wbBase.Url;
                        HtmlAgilityPack.HtmlDocument adoc = new HtmlAgilityPack.HtmlDocument();
                        adoc.LoadHtml(html);
                        foreach (HtmlAgilityPack.HtmlNode link in adoc.DocumentNode.SelectNodes("//a[@href]"))
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

        private void tssbInsertURLs_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                string all = Clipboard.GetText();
                txtTmp.Text = all;
                foreach (string line in txtTmp.Lines)
                {
                    listUrls.Items.Add(line);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }


        }

        private string[] getDeployedLines(string durl)
        {
            List<string> rets = new List<string>();
            if(string.IsNullOrEmpty(durl))
                return rets.ToArray();

            int lkakko = durl.IndexOf('[',0);
            if(lkakko < 0)
                return rets.ToArray();

            int rkakko = durl.IndexOf(']',lkakko);
            if(rkakko <0)
                return rets.ToArray();

            string allcont = durl.Substring(lkakko+1, rkakko-lkakko-1);
            string[] tmp = allcont.Split('-');
            if(tmp.Length!=2)
                return rets.ToArray();

            string startindex = tmp[0];
            int istartindex;
            if(!int.TryParse(startindex, out istartindex))
                return rets.ToArray();

            string secondpart = tmp[1];
            int iendindex=0;
            int step = 0;
            tmp = secondpart.Split(',');
            if(tmp.Length==1)
            {
                string endindex = tmp[0];
                if(!int.TryParse(endindex, out iendindex))
                    return rets.ToArray();

            }
            else if(tmp.Length==2)
            {
                string endindex = tmp[0];
                if(!int.TryParse(endindex, out iendindex))
                    return rets.ToArray();

                string stepstring = tmp[1];
                if(!int.TryParse(stepstring, out step))
                    return rets.ToArray();
            }
            else
            {
                return rets.ToArray();
            }

            if(step==0)
                step=1;

            for(int i=istartindex ; i <= iendindex ; i=i+step)
            {
                string dekita = durl.Substring(0, lkakko);
                dekita += i.ToString();
                dekita += durl.Substring(rkakko + 1);
                rets.Add(dekita);
            }
            return rets.ToArray();
        }
        private void deployRangedURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string all = Clipboard.GetText();
                txtTmp.Text = all;
                foreach (string line in txtTmp.Lines)
                {
                    string[] deployedlines = getDeployedLines(line);
                    foreach (string dl in deployedlines)
                    {
                        listUrls.Items.Add(dl);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, Application.ProductName); }

        }




   
    }

    class WaitCursor : IDisposable
    {
        //private Form f_;
        private Cursor org_;
        internal WaitCursor()
        {
            // f_ = f;
            // org_ = Application.UseWaitCursor;
            // Application.UseWaitCursor = true;
            org_ = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            Cursor.Current = org_;
        }
    }

}
