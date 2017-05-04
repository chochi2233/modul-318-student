namespace SwissTransport
{
    partial class Fahrplan
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
            this.listBoxplan = new System.Windows.Forms.ListBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.comboboxstation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxplan
            // 
            this.listBoxplan.FormattingEnabled = true;
            this.listBoxplan.ItemHeight = 16;
            this.listBoxplan.Location = new System.Drawing.Point(16, 175);
            this.listBoxplan.Name = "listBoxplan";
            this.listBoxplan.Size = new System.Drawing.Size(739, 196);
            this.listBoxplan.TabIndex = 27;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(16, 110);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 26;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // comboboxstation
            // 
            this.comboboxstation.FormattingEnabled = true;
            this.comboboxstation.Location = new System.Drawing.Point(16, 80);
            this.comboboxstation.Name = "comboboxstation";
            this.comboboxstation.Size = new System.Drawing.Size(263, 24);
            this.comboboxstation.TabIndex = 25;
            this.comboboxstation.TextUpdate += new System.EventHandler(this.comboboxstation_TextUpdate);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Station";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nächsten Verbindungen von";
            // 
            // lblstation
            // 
            this.lblstation.AutoSize = true;
            this.lblstation.Location = new System.Drawing.Point(198, 141);
            this.lblstation.Name = "lblstation";
            this.lblstation.Size = new System.Drawing.Size(72, 17);
            this.lblstation.TabIndex = 30;
            this.lblstation.Text = "________";
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblstation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxplan);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboboxstation);
            this.Name = "Fahrplan";
            this.Size = new System.Drawing.Size(898, 546);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxplan;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox comboboxstation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstation;
    }
}
