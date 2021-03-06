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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verbindungen));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new System.Windows.Forms.Button();
            this.comboBoxnach = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxvon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnkartevon = new System.Windows.Forms.Button();
            this.btnkartenach = new System.Windows.Forms.Button();
            this.listViewplan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy   ||   HH.mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 22);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2017, 5, 4, 10, 34, 12, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(595, 138);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(120, 57);
            this.btnsearch.TabIndex = 18;
            this.btnsearch.Text = "Verbindung suchen";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // comboBoxnach
            // 
            this.comboBoxnach.FormattingEnabled = true;
            this.comboBoxnach.Location = new System.Drawing.Point(368, 80);
            this.comboBoxnach.Name = "comboBoxnach";
            this.comboBoxnach.Size = new System.Drawing.Size(313, 24);
            this.comboBoxnach.TabIndex = 17;
            this.comboBoxnach.SelectedIndexChanged += new System.EventHandler(this.comboBoxnach_SelectedIndexChanged);
            this.comboBoxnach.TextUpdate += new System.EventHandler(this.comboBoxnach_TextUpdate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 140);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 62);
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
            this.comboBoxvon.Size = new System.Drawing.Size(315, 24);
            this.comboBoxvon.TabIndex = 16;
            this.comboBoxvon.SelectedIndexChanged += new System.EventHandler(this.comboBoxvon_SelectedIndexChanged);
            this.comboBoxvon.TextUpdate += new System.EventHandler(this.comboBoxvon_TextUpdate);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Verbindungen";
            // 
            // btnkartevon
            // 
            this.btnkartevon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkartevon.BackgroundImage")));
            this.btnkartevon.Location = new System.Drawing.Point(337, 80);
            this.btnkartevon.Name = "btnkartevon";
            this.btnkartevon.Size = new System.Drawing.Size(25, 25);
            this.btnkartevon.TabIndex = 29;
            this.btnkartevon.UseVisualStyleBackColor = true;
            this.btnkartevon.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnkartenach
            // 
            this.btnkartenach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnkartenach.BackgroundImage")));
            this.btnkartenach.Location = new System.Drawing.Point(687, 81);
            this.btnkartenach.Name = "btnkartenach";
            this.btnkartenach.Size = new System.Drawing.Size(25, 25);
            this.btnkartenach.TabIndex = 30;
            this.btnkartenach.UseVisualStyleBackColor = true;
            this.btnkartenach.Click += new System.EventHandler(this.btnkartenach_Click);
            // 
            // listViewplan
            // 
            this.listViewplan.Location = new System.Drawing.Point(16, 239);
            this.listViewplan.Name = "listViewplan";
            this.listViewplan.Size = new System.Drawing.Size(699, 196);
            this.listViewplan.TabIndex = 31;
            this.listViewplan.UseCompatibleStateImageBehavior = false;
            // 
            // Verbindungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewplan);
            this.Controls.Add(this.btnkartenach);
            this.Controls.Add(this.btnkartevon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.comboBoxnach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxvon);
            this.Controls.Add(this.label1);
            this.Name = "Verbindungen";
            this.Size = new System.Drawing.Size(749, 453);
            this.Load += new System.EventHandler(this.Verbindungen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox comboBoxnach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxvon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnkartevon;
        private System.Windows.Forms.Button btnkartenach;
        private System.Windows.Forms.ListView listViewplan;
    }
}
