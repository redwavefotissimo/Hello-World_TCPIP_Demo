namespace TCPIP_Demo
{
    partial class ServerForm
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
            this.BTNStart = new System.Windows.Forms.Button();
            this.ServerAddress = new System.Windows.Forms.Label();
            this.BTNOpenClientForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNStart
            // 
            this.BTNStart.Location = new System.Drawing.Point(197, 12);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(75, 23);
            this.BTNStart.TabIndex = 0;
            this.BTNStart.Text = "Start";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // ServerAddress
            // 
            this.ServerAddress.AutoSize = true;
            this.ServerAddress.Location = new System.Drawing.Point(12, 17);
            this.ServerAddress.Name = "ServerAddress";
            this.ServerAddress.Size = new System.Drawing.Size(76, 13);
            this.ServerAddress.TabIndex = 1;
            this.ServerAddress.Text = "ServerAddress";
            // 
            // BTNOpenClientForm
            // 
            this.BTNOpenClientForm.Location = new System.Drawing.Point(13, 46);
            this.BTNOpenClientForm.Name = "BTNOpenClientForm";
            this.BTNOpenClientForm.Size = new System.Drawing.Size(259, 23);
            this.BTNOpenClientForm.TabIndex = 2;
            this.BTNOpenClientForm.Text = "Open Client Form";
            this.BTNOpenClientForm.UseVisualStyleBackColor = true;
            this.BTNOpenClientForm.Click += new System.EventHandler(this.BTNOpenClientForm_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BTNOpenClientForm);
            this.Controls.Add(this.ServerAddress);
            this.Controls.Add(this.BTNStart);
            this.Name = "ServerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Label ServerAddress;
        private System.Windows.Forms.Button BTNOpenClientForm;
    }
}

