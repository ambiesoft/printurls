using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mshtml;
using Ambiesoft;
using System.Diagnostics;
using System.Web;

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
                string format = "{0} Items";

                slItemCount.Text = string.Format(format, listUrls.Items.Count);
            }
        }
        private void FormIterate_Load(object sender, EventArgs e)
        {
            // BeginInvoke(new dele(doit));
            wbBase.Navigate(_url);
        }
        
        void addToListIfNotEmpty(string url)
        {
            if (string.IsNullOrEmpty(url))
                return;

            url = url.Trim();

            if (string.IsNullOrEmpty(url))
                return;

            listUrls.Items.Add(url);
        }
        internal static string GetSourceUrlFromHtml(string html)
        {
            if (string.IsNullOrEmpty(html))
                return string.Empty;

            string firstparg = "SourceURL:";
            html = html.Replace("\r\n", "\n").Replace("\r", "\n");
            foreach(string fragment in html.Split('\n'))
            {
                if (fragment.IndexOf(firstparg) == 0)
                {
                    return fragment.Substring(firstparg.Length);
                }
            }
            return string.Empty;
        }
        internal static string[] GetUrlsFromHtml(string html)
        {
            return GetUrlsFromHtml(html, null);
        }
        internal static string[] GetUrlsFromHtml(string html, string baseUrl)
        {
            List<string> ret = new List<string>();
            if (baseUrl == null)
                baseUrl = GetSourceUrlFromHtml(html);

            HtmlAgilityPack.HtmlDocument adoc = new HtmlAgilityPack.HtmlDocument();
            adoc.LoadHtml(html);
            if (adoc.DocumentNode == null)
                return new string[0];
            HtmlAgilityPack.HtmlNodeCollection nodes;
            try
            {
                nodes = adoc.DocumentNode.SelectNodes("//a[@href]");
            }
            catch(Exception)
            {
                return new string[0];
            }
            foreach (HtmlAgilityPack.HtmlNode link in nodes)
            {
                string url = HttpUtility.HtmlDecode(link.Attributes["href"].Value.ToString());
                Uri u = string.IsNullOrEmpty(baseUrl) ? new Uri(url) : new Uri(new Uri(baseUrl), url);
                ret.Add(u.AbsoluteUri);
            }
            return ret.ToArray();
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
                        switch (CppUtils.CenteredMessageBox(this,
                            Properties.Resources.CancelCompleteCheck,
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

                        string[] urls = GetUrlsFromHtml(html, wbBase.Url.AbsoluteUri);
                        foreach (string url in urls)
                            addToListIfNotEmpty(url);
                    }
                    catch (Exception ex)
                    {
                        CppUtils.CenteredMessageBox(this,
                            ex.Message,
                            Application.ProductName,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    HtmlDocument doc = wbBase.Document;
                    Dictionary<string, int> tagcounter = new Dictionary<string, int>();
                    // List<string> urls = new List<string>();
                    foreach (HtmlElement elm in doc.All)
                    {
                        if (elm.TagName == "a" || elm.TagName == "A")
                        {
                            string url = elm.GetAttribute("href");
                            // urls.Add(url);
                            // listUrls.Items.Add(url);
                            addToListIfNotEmpty(url);
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
        private void btnCrop_Click(object sender, EventArgs e)
        {
            if(listUrls.SelectedItems.Count==0)
            {
                CppUtils.Alert(this, Properties.Resources.NO_ITEM_SELECTED);
                return;
            }

            foreach(ListViewItem item in listUrls.Items)
            {
                if (!item.Selected)
                    item.Remove();
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
            
            if(_retresult.Count==0)
            {
                Program.showerror(printurls.Properties.Resources.NOURL);
                this.DialogResult=DialogResult.None;
            }
        }

        private void tsbExtractAllLinks_Click(object sender, EventArgs e)
        {
            ExtractLinks(false);
            listUrls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void tsbExtractSelectedLinks_Click(object sender, EventArgs e)
        {
            ExtractLinks(true);
            listUrls.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
            catch (Exception ex) { CppUtils.CenteredMessageBox(this, ex.Message, Application.ProductName); }


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
            catch (Exception ex) { CppUtils.CenteredMessageBox(this, ex.Message, Application.ProductName); }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(listUrls.SelectedItems[0].Text);
            }
            catch (Exception ex)
            {
                CppUtils.CenteredMessageBox(this, ex.Message, Application.ProductName);
            }
        }

        private void tsCopyAll_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in listUrls.Items)
            {
                sb.AppendLine(item.Text);
            }

            try
            {
                Clipboard.SetText(sb.ToString());
            }
            catch (Exception ex)
            {
                CppUtils.CenteredMessageBox(this,
                    ex.Message,
                    Application.ProductName);
            }
        }

        private void tsPaste_Click(object sender, EventArgs e)
        {

        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            listUrls.Items.Clear();
        }

        void clearSelection()
        {
            foreach(ListViewItem item in listUrls.Items)
            {
                item.Selected = false;
            }
        }
        int findDup(int iStart, string text)
        {
            for (int i = iStart; i < listUrls.Items.Count; ++i)
            {
                string testtext = listUrls.Items[i].Text;
                if (testtext == text)
                    return i;
            }
            return -1;
        }
        private void btnFindDuplicates_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listUrls.Items.Count; ++i)
            {
                int found = findDup(i + 1, listUrls.Items[i].Text);
                if (found >= 0)
                {
                    clearSelection();
                    listUrls.Items[i].Focused = listUrls.Items[i].Selected = true;
                    listUrls.Items[found].Focused = listUrls.Items[found].Selected = true;

                    listUrls.EnsureVisible(i);

                    CppUtils.CenteredMessageBox(this,
                        Properties.Resources.DUPITEM_FOUND,
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

            CppUtils.CenteredMessageBox(this,
                          Properties.Resources.NO_DUPITEM_FOUND,
                          Application.ProductName,
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            foreach(ListViewItem item in listUrls.SelectedItems)
            {
                if (!first)
                    sb.AppendLine();
                else
                    first = false;

                sb.Append(item.Text);
            }

            try
            {
                Clipboard.SetText(sb.ToString());
            }
            catch(Exception ex)
            {
                CppUtils.Alert(ex);
            }
        }

        //protected override void OnDragEnter(DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Html))
        //    {
        //        e.Effect = DragDropEffects.Copy;
        //    }

        //    // call the base OnDragEnter event
        //    base.OnDragEnter(e);
        //}


    




   
    }

    public class MyDragAndDropListView : DragNDrop.DragAndDropListView
    {
        protected override void OnDragOver(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Html))
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
            base.OnDragOver(e);
        }
        protected override void OnDragDrop(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Html))
            {
                object o = e.Data.GetData(DataFormats.Html);
                if (o == null)
                    return;
                string[] urls = FormIterate.GetUrlsFromHtml(o.ToString());
                foreach (string url in urls)
                    Items.Add(url);
                return;
            }
            base.OnDragDrop(e);
        }
        protected override void OnDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Html))
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
            base.OnDragEnter(e);
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
