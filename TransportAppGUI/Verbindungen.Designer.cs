﻿namespace SwissTransport
{
    partial class Verbindungen
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.comboBoxnach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxvon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxplan
            // 
            this.listBoxplan.FormattingEnabled = true;
            this.listBoxplan.ItemHeight = 16;
            this.listBoxplan.Location = new System.Drawing.Point(16, 239);
            this.listBoxplan.Name = "listBoxplan";
            this.listBoxplan.Size = new System.Drawing.Size(739, 196);
            this.listBoxplan.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(680, 82);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 22;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // comboBoxnach
            // 
            this.comboBoxnach.FormattingEnabled = true;
            this.comboBoxnach.Location = new System.Drawing.Point(296, 82);
            this.comboBoxnach.Name = "comboBoxnach";
            this.comboBoxnach.Size = new System.Drawing.Size(257, 24);
            this.comboBoxnach.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zeit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Datum";
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(296, 160);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(61, 22);
            this.txtmin.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nach";
            // 
            // comboBoxvon
            // 
            this.comboBoxvon.FormattingEnabled = true;
            this.comboBoxvon.Location = new System.Drawing.Point(16, 81);
            this.comboBoxvon.Name = "comboBoxvon";
            this.comboBoxvon.Size = new System.Drawing.Size(257, 24);
            this.comboBoxvon.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Von";
            // 
            // txtsec
            // 
            this.txtsec.Location = new System.Drawing.Point(383, 162);
            this.txtsec.Name = "txtsec";
            this.txtsec.Size = new System.Drawing.Size(61, 22);
            this.txtsec.TabIndex = 26;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtsec);
            this.Controls.Add(this.listBoxplan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboBoxnach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxvon);
            this.Controls.Add(this.label1);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(898, 546);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxplan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox comboBoxnach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxvon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsec;
    }
}