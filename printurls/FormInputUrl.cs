using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace printurls
{
    public partial class FormInputUrl : Form
    {
        public FormInputUrl()
        {
            InitializeComponent();
        }

        private void FormInputUrl_Load(object sender, EventArgs e)
        {
            try
            {
                txtUrl.Text = Clipboard.GetText();
            }
            catch (Exception) { }
        }
    }
}
