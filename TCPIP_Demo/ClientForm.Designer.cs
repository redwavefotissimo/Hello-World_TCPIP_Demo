﻿namespace TCPIP_Demo
{
    partial class ClientForm
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
            this.BTNSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.JobDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNSend
            // 
            this.BTNSend.Location = new System.Drawing.Point(197, 12);
            this.BTNSend.Name = "BTNSend";
            this.BTNSend.Size = new System.Drawing.Size(75, 23);
            this.BTNSend.TabIndex = 0;
            this.BTNSend.Text = "Send";
            this.BTNSend.UseVisualStyleBackColor = true;
            this.BTNSend.Click += new System.EventHandler(this.BTNSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 1;
            // 
            // JobDescription
            // 
            this.JobDescription.AutoSize = true;
            this.JobDescription.Location = new System.Drawing.Point(12, 44);
            this.JobDescription.Name = "JobDescription";
            this.JobDescription.Size = new System.Drawing.Size(77, 13);
            this.JobDescription.TabIndex = 2;
            this.JobDescription.Text = "JobDescription";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.JobDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNSend);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label JobDescription;
    }
}