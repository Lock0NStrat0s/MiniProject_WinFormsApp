namespace MiniProject_WinForms
{
    partial class Information
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
            this._lblName = new System.Windows.Forms.Label();
            this._txtbName = new System.Windows.Forms.TextBox();
            this._btnGetAddress = new System.Windows.Forms.Button();
            this._lstbInformation = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(79, 52);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(47, 16);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Name:";
            // 
            // _txtbName
            // 
            this._txtbName.Location = new System.Drawing.Point(153, 49);
            this._txtbName.Name = "_txtbName";
            this._txtbName.Size = new System.Drawing.Size(164, 22);
            this._txtbName.TabIndex = 1;
            // 
            // _btnGetAddress
            // 
            this._btnGetAddress.Location = new System.Drawing.Point(355, 49);
            this._btnGetAddress.Name = "_btnGetAddress";
            this._btnGetAddress.Size = new System.Drawing.Size(126, 49);
            this._btnGetAddress.TabIndex = 2;
            this._btnGetAddress.Text = "Get Address";
            this._btnGetAddress.UseVisualStyleBackColor = true;
            this._btnGetAddress.Click += new System.EventHandler(this._btnGetAddress_Click);
            // 
            // _lstbInformation
            // 
            this._lstbInformation.FormattingEnabled = true;
            this._lstbInformation.ItemHeight = 16;
            this._lstbInformation.Location = new System.Drawing.Point(82, 140);
            this._lstbInformation.Name = "_lstbInformation";
            this._lstbInformation.Size = new System.Drawing.Size(399, 164);
            this._lstbInformation.TabIndex = 3;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lstbInformation);
            this.Controls.Add(this._btnGetAddress);
            this.Controls.Add(this._txtbName);
            this.Controls.Add(this._lblName);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.TextBox _txtbName;
        private System.Windows.Forms.Button _btnGetAddress;
        private System.Windows.Forms.ListBox _lstbInformation;
    }
}

