namespace SwissTransport
{
    partial class Karte
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowserkarte = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserkarte
            // 
            this.webBrowserkarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserkarte.Location = new System.Drawing.Point(0, 0);
            this.webBrowserkarte.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserkarte.Name = "webBrowserkarte";
            this.webBrowserkarte.Size = new System.Drawing.Size(1021, 557);
            this.webBrowserkarte.TabIndex = 0;
            this.webBrowserkarte.Url = new System.Uri("http://google.ch", System.UriKind.Absolute);
            this.webBrowserkarte.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserkarte_DocumentCompleted);
            // 
            // Karte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowserkarte);
            this.Name = "Karte";
            this.Size = new System.Drawing.Size(1021, 557);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserkarte;
    }
}
