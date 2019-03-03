using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormBaseLib;
using CefSharpBrowserLib;

namespace WebFormBase
{
    public partial class WebBaseForm : FormBase
    {
        IBrowser webBrowser;
        public WebBaseForm()
        {
            InitializeComponent();
            webBrowser = new CefWebBrowser(panelMainM);
            webBrowser.LoadCompleted = BrowserPageloaded;
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUrl.Text))
                webBrowser.Navigate(tbUrl.Text);
        }

        void BrowserPageloaded()
        {
            tbUrl.Text = webBrowser.Address;
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUrl.Text))
            {
                btnNavigate.Enabled = false;
            }
            else
            {
                if (!btnNavigate.Enabled)
                    btnNavigate.Enabled = true;
            }
        }

        private void tbUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (!string.IsNullOrEmpty(tbUrl.Text))
                {
                    webBrowser.Navigate(tbUrl.Text);
                }
            }
        }
    }
}
