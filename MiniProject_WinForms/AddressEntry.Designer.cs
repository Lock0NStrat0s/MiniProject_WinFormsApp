namespace MiniProject_WinForms
{
    partial class AddressEntry
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
            this._txtbCity = new System.Windows.Forms.TextBox();
            this._lblCity = new System.Windows.Forms.Label();
            this._txtbStreetAddress = new System.Windows.Forms.TextBox();
            this._lblStreetAddress = new System.Windows.Forms.Label();
            this._txtbPostalCode = new System.Windows.Forms.TextBox();
            this._lblPostalCode = new System.Windows.Forms.Label();
            this._txtbProvince = new System.Windows.Forms.TextBox();
            this._lblProvince = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtbCity
            // 
            this._txtbCity.Location = new System.Drawing.Point(182, 151);
            this._txtbCity.Margin = new System.Windows.Forms.Padding(4);
            this._txtbCity.Name = "_txtbCity";
            this._txtbCity.Size = new System.Drawing.Size(409, 27);
            this._txtbCity.TabIndex = 7;
            // 
            // _lblCity
            // 
            this._lblCity.AutoSize = true;
            this._lblCity.Location = new System.Drawing.Point(135, 158);
            this._lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCity.Name = "_lblCity";
            this._lblCity.Size = new System.Drawing.Size(43, 20);
            this._lblCity.TabIndex = 8;
            this._lblCity.Text = "City:";
            // 
            // _txtbStreetAddress
            // 
            this._txtbStreetAddress.Location = new System.Drawing.Point(182, 101);
            this._txtbStreetAddress.Margin = new System.Windows.Forms.Padding(4);
            this._txtbStreetAddress.Name = "_txtbStreetAddress";
            this._txtbStreetAddress.Size = new System.Drawing.Size(409, 27);
            this._txtbStreetAddress.TabIndex = 6;
            // 
            // _lblStreetAddress
            // 
            this._lblStreetAddress.AutoSize = true;
            this._lblStreetAddress.Location = new System.Drawing.Point(50, 105);
            this._lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblStreetAddress.Name = "_lblStreetAddress";
            this._lblStreetAddress.Size = new System.Drawing.Size(126, 20);
            this._lblStreetAddress.TabIndex = 5;
            this._lblStreetAddress.Text = "Street Address:";
            // 
            // _txtbPostalCode
            // 
            this._txtbPostalCode.Location = new System.Drawing.Point(182, 257);
            this._txtbPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this._txtbPostalCode.Name = "_txtbPostalCode";
            this._txtbPostalCode.Size = new System.Drawing.Size(409, 27);
            this._txtbPostalCode.TabIndex = 11;
            // 
            // _lblPostalCode
            // 
            this._lblPostalCode.AutoSize = true;
            this._lblPostalCode.Location = new System.Drawing.Point(69, 257);
            this._lblPostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblPostalCode.Name = "_lblPostalCode";
            this._lblPostalCode.Size = new System.Drawing.Size(105, 20);
            this._lblPostalCode.TabIndex = 12;
            this._lblPostalCode.Text = "Postal Code:";
            // 
            // _txtbProvince
            // 
            this._txtbProvince.Location = new System.Drawing.Point(182, 207);
            this._txtbProvince.Margin = new System.Windows.Forms.Padding(4);
            this._txtbProvince.Name = "_txtbProvince";
            this._txtbProvince.Size = new System.Drawing.Size(409, 27);
            this._txtbProvince.TabIndex = 10;
            // 
            // _lblProvince
            // 
            this._lblProvince.AutoSize = true;
            this._lblProvince.Location = new System.Drawing.Point(95, 214);
            this._lblProvince.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblProvince.Name = "_lblProvince";
            this._lblProvince.Size = new System.Drawing.Size(79, 20);
            this._lblProvince.TabIndex = 9;
            this._lblProvince.Text = "Province:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Address Entry";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(245, 308);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(169, 63);
            this._btnSave.TabIndex = 14;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 490);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtbPostalCode);
            this.Controls.Add(this._lblPostalCode);
            this.Controls.Add(this._txtbProvince);
            this.Controls.Add(this._lblProvince);
            this.Controls.Add(this._txtbCity);
            this.Controls.Add(this._lblCity);
            this.Controls.Add(this._txtbStreetAddress);
            this.Controls.Add(this._lblStreetAddress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddressEntry";
            this.Text = "AddressEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtbCity;
        private System.Windows.Forms.Label _lblCity;
        private System.Windows.Forms.TextBox _txtbStreetAddress;
        private System.Windows.Forms.Label _lblStreetAddress;
        private System.Windows.Forms.TextBox _txtbPostalCode;
        private System.Windows.Forms.Label _lblPostalCode;
        private System.Windows.Forms.TextBox _txtbProvince;
        private System.Windows.Forms.Label _lblProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnSave;
    }
}