using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TSBSearch_Click(object sender, EventArgs e)
        {
            WBWindow.Navigate(TSBSearch.Text);
        }

        private void TSBStop_Click(object sender, EventArgs e)
        {
            WBWindow.Stop();
        }

        private void TSBBack_Click(object sender, EventArgs e)
        {
            WBWindow.GoBack();
        }

        private void TSBRefresh_Click(object sender, EventArgs e)
        {
            WBWindow.Refresh();
        }

        private void WBWindow_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            try
            {
                toolStripProgressBar1.Value = (int)e.CurrentProgress;
            }
            catch
            { 

            }
        }

        private void WBWindow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
        }
    }
}
