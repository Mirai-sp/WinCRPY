﻿namespace WinCRPY
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            button1 = new Button();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            lblDevelopedBy = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(445, 147);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 71);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 10;
            label2.Text = "This is a freeware software.";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(181, 56);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(158, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/Mirai-sp";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblDevelopedBy
            // 
            lblDevelopedBy.AutoSize = true;
            lblDevelopedBy.Location = new Point(181, 41);
            lblDevelopedBy.Name = "lblDevelopedBy";
            lblDevelopedBy.Size = new Size(342, 15);
            lblDevelopedBy.TabIndex = 8;
            lblDevelopedBy.Text = "Este aplicativo foi desenvolvido por Denis Queiroz (2002 - 2023).";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(177, 11);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 7;
            label1.Text = "WinCRPY";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Lock_Lock_icon;
            pictureBox1.Location = new Point(9, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 181);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(lblDevelopedBy);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAbout";
            Load += frmAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private LinkLabel linkLabel1;
        private Label lblDevelopedBy;
        private Label label1;
        private PictureBox pictureBox1;
    }
}