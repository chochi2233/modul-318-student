namespace SwissTransport
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
            this.btnverbindungen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfahrplan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnverbindungen
            // 
            this.btnverbindungen.Location = new System.Drawing.Point(24, 13);
            this.btnverbindungen.Name = "btnverbindungen";
            this.btnverbindungen.Size = new System.Drawing.Size(106, 34);
            this.btnverbindungen.TabIndex = 0;
            this.btnverbindungen.Text = "Verbindungen";
            this.btnverbindungen.UseVisualStyleBackColor = true;
            this.btnverbindungen.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 448);
            this.panel1.TabIndex = 1;
            // 
            // btnfahrplan
            // 
            this.btnfahrplan.Location = new System.Drawing.Point(136, 13);
            this.btnfahrplan.Name = "btnfahrplan";
            this.btnfahrplan.Size = new System.Drawing.Size(106, 34);
            this.btnfahrplan.TabIndex = 2;
            this.btnfahrplan.Text = "Fahrplan";
            this.btnfahrplan.UseVisualStyleBackColor = true;
            this.btnfahrplan.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 513);
            this.Controls.Add(this.btnfahrplan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnverbindungen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnverbindungen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfahrplan;
    }
}

