namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslone = new System.Windows.Forms.ToolStripLabel();
            this.TSTSearch = new System.Windows.Forms.ToolStripTextBox();
            this.TSBSearch = new System.Windows.Forms.ToolStripButton();
            this.TSBStop = new System.Windows.Forms.ToolStripButton();
            this.TSBBack = new System.Windows.Forms.ToolStripButton();
            this.TSBRefresh = new System.Windows.Forms.ToolStripButton();
            this.WBWindow = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslone,
            this.TSTSearch,
            this.TSBSearch,
            this.TSBStop,
            this.TSBBack,
            this.TSBRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(963, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslone
            // 
            this.tslone.Name = "tslone";
            this.tslone.Size = new System.Drawing.Size(34, 22);
            this.tslone.Text = "URL: ";
            // 
            // TSTSearch
            // 
            this.TSTSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TSTSearch.Name = "TSTSearch";
            this.TSTSearch.Size = new System.Drawing.Size(500, 25);
            // 
            // TSBSearch
            // 
            this.TSBSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBSearch.Image = ((System.Drawing.Image)(resources.GetObject("TSBSearch.Image")));
            this.TSBSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSearch.Name = "TSBSearch";
            this.TSBSearch.Size = new System.Drawing.Size(46, 22);
            this.TSBSearch.Text = "Search";
            this.TSBSearch.Click += new System.EventHandler(this.TSBSearch_Click);
            // 
            // TSBStop
            // 
            this.TSBStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBStop.Image = ((System.Drawing.Image)(resources.GetObject("TSBStop.Image")));
            this.TSBStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBStop.Name = "TSBStop";
            this.TSBStop.Size = new System.Drawing.Size(35, 22);
            this.TSBStop.Text = "Stop";
            this.TSBStop.Click += new System.EventHandler(this.TSBStop_Click);
            // 
            // TSBBack
            // 
            this.TSBBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBBack.Image = ((System.Drawing.Image)(resources.GetObject("TSBBack.Image")));
            this.TSBBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBack.Name = "TSBBack";
            this.TSBBack.Size = new System.Drawing.Size(36, 22);
            this.TSBBack.Text = "Back";
            this.TSBBack.Click += new System.EventHandler(this.TSBBack_Click);
            // 
            // TSBRefresh
            // 
            this.TSBRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSBRefresh.Image = ((System.Drawing.Image)(resources.GetObject("TSBRefresh.Image")));
            this.TSBRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBRefresh.Name = "TSBRefresh";
            this.TSBRefresh.Size = new System.Drawing.Size(50, 22);
            this.TSBRefresh.Text = "Refresh";
            this.TSBRefresh.Click += new System.EventHandler(this.TSBRefresh_Click);
            // 
            // WBWindow
            // 
            this.WBWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WBWindow.Location = new System.Drawing.Point(0, 0);
            this.WBWindow.MinimumSize = new System.Drawing.Size(20, 20);
            this.WBWindow.Name = "WBWindow";
            this.WBWindow.Size = new System.Drawing.Size(963, 575);
            this.WBWindow.TabIndex = 0;
            this.WBWindow.Url = new System.Uri("http://www.yandex.com", System.UriKind.Absolute);
            this.WBWindow.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WBWindow_DocumentCompleted);
            this.WBWindow.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WBWindow_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(963, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 575);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.WBWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslone;
        private System.Windows.Forms.ToolStripTextBox TSTSearch;
        private System.Windows.Forms.ToolStripButton TSBSearch;
        private System.Windows.Forms.ToolStripButton TSBStop;
        private System.Windows.Forms.ToolStripButton TSBBack;
        private System.Windows.Forms.ToolStripButton TSBRefresh;
        private System.Windows.Forms.WebBrowser WBWindow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

