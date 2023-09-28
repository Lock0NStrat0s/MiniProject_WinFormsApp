namespace MiniProject_WinForms
{
    partial class Address
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
            this._lblAddress = new System.Windows.Forms.Label();
            this._txtbAddress = new System.Windows.Forms.TextBox();
            this._btnAddInfo = new System.Windows.Forms.Button();
            this._btnAddAddress = new System.Windows.Forms.Button();
            this._lstbAddresses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _lblAddress
            // 
            this._lblAddress.AutoSize = true;
            this._lblAddress.Location = new System.Drawing.Point(73, 53);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(136, 16);
            this._lblAddress.TabIndex = 0;
            this._lblAddress.Text = "What is your address:";
            // 
            // _txtbAddress
            // 
            this._txtbAddress.Location = new System.Drawing.Point(250, 51);
            this._txtbAddress.Name = "_txtbAddress";
            this._txtbAddress.Size = new System.Drawing.Size(200, 22);
            this._txtbAddress.TabIndex = 1;
            // 
            // _btnAddInfo
            // 
            this._btnAddInfo.Location = new System.Drawing.Point(486, 332);
            this._btnAddInfo.Name = "_btnAddInfo";
            this._btnAddInfo.Size = new System.Drawing.Size(137, 64);
            this._btnAddInfo.TabIndex = 2;
            this._btnAddInfo.Text = "Add Info";
            this._btnAddInfo.UseVisualStyleBackColor = true;
            this._btnAddInfo.Click += new System.EventHandler(this._btnAddInfo_Click);
            // 
            // _btnAddAddress
            // 
            this._btnAddAddress.Location = new System.Drawing.Point(486, 53);
            this._btnAddAddress.Name = "_btnAddAddress";
            this._btnAddAddress.Size = new System.Drawing.Size(95, 40);
            this._btnAddAddress.TabIndex = 3;
            this._btnAddAddress.Text = "Add Address";
            this._btnAddAddress.UseVisualStyleBackColor = true;
            this._btnAddAddress.Click += new System.EventHandler(this._btnAddAddress_Click);
            // 
            // _lstbAddresses
            // 
            this._lstbAddresses.FormattingEnabled = true;
            this._lstbAddresses.ItemHeight = 16;
            this._lstbAddresses.Location = new System.Drawing.Point(76, 116);
            this._lstbAddresses.Name = "_lstbAddresses";
            this._lstbAddresses.Size = new System.Drawing.Size(374, 164);
            this._lstbAddresses.TabIndex = 4;
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lstbAddresses);
            this.Controls.Add(this._btnAddAddress);
            this.Controls.Add(this._btnAddInfo);
            this.Controls.Add(this._txtbAddress);
            this.Controls.Add(this._lblAddress);
            this.Name = "Address";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.TextBox _txtbAddress;
        private System.Windows.Forms.Button _btnAddInfo;
        private System.Windows.Forms.Button _btnAddAddress;
        private System.Windows.Forms.ListBox _lstbAddresses;
    }
}