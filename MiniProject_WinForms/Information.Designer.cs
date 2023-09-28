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
            this._lblFirstName = new System.Windows.Forms.Label();
            this._txtbFirstName = new System.Windows.Forms.TextBox();
            this._btnAdd = new System.Windows.Forms.Button();
            this._lstbInformation = new System.Windows.Forms.ListBox();
            this._lblLastName = new System.Windows.Forms.Label();
            this._txtbLastName = new System.Windows.Forms.TextBox();
            this._chkbIsActive = new System.Windows.Forms.CheckBox();
            this._lblActive = new System.Windows.Forms.Label();
            this._lblAddresses = new System.Windows.Forms.Label();
            this._btnSaveRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblFirstName
            // 
            this._lblFirstName.AutoSize = true;
            this._lblFirstName.Location = new System.Drawing.Point(99, 65);
            this._lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblFirstName.Name = "_lblFirstName";
            this._lblFirstName.Size = new System.Drawing.Size(97, 20);
            this._lblFirstName.TabIndex = 0;
            this._lblFirstName.Text = "First Name:";
            // 
            // _txtbFirstName
            // 
            this._txtbFirstName.Location = new System.Drawing.Point(191, 61);
            this._txtbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this._txtbFirstName.Name = "_txtbFirstName";
            this._txtbFirstName.Size = new System.Drawing.Size(409, 27);
            this._txtbFirstName.TabIndex = 1;
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(506, 236);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(95, 42);
            this._btnAdd.TabIndex = 4;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _lstbInformation
            // 
            this._lstbInformation.FormattingEnabled = true;
            this._lstbInformation.ItemHeight = 20;
            this._lstbInformation.Location = new System.Drawing.Point(102, 286);
            this._lstbInformation.Margin = new System.Windows.Forms.Padding(4);
            this._lstbInformation.Name = "_lstbInformation";
            this._lstbInformation.Size = new System.Drawing.Size(498, 204);
            this._lstbInformation.TabIndex = 3;
            this._lstbInformation.TabStop = false;
            // 
            // _lblLastName
            // 
            this._lblLastName.AutoSize = true;
            this._lblLastName.Location = new System.Drawing.Point(99, 115);
            this._lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblLastName.Name = "_lblLastName";
            this._lblLastName.Size = new System.Drawing.Size(96, 20);
            this._lblLastName.TabIndex = 4;
            this._lblLastName.Text = "Last Name:";
            // 
            // _txtbLastName
            // 
            this._txtbLastName.Location = new System.Drawing.Point(191, 111);
            this._txtbLastName.Margin = new System.Windows.Forms.Padding(4);
            this._txtbLastName.Name = "_txtbLastName";
            this._txtbLastName.Size = new System.Drawing.Size(409, 27);
            this._txtbLastName.TabIndex = 2;
            // 
            // _chkbIsActive
            // 
            this._chkbIsActive.AutoSize = true;
            this._chkbIsActive.Location = new System.Drawing.Point(191, 161);
            this._chkbIsActive.Margin = new System.Windows.Forms.Padding(4);
            this._chkbIsActive.Name = "_chkbIsActive";
            this._chkbIsActive.Size = new System.Drawing.Size(18, 17);
            this._chkbIsActive.TabIndex = 3;
            this._chkbIsActive.UseVisualStyleBackColor = true;
            // 
            // _lblActive
            // 
            this._lblActive.AutoSize = true;
            this._lblActive.Location = new System.Drawing.Point(99, 162);
            this._lblActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblActive.Name = "_lblActive";
            this._lblActive.Size = new System.Drawing.Size(65, 20);
            this._lblActive.TabIndex = 7;
            this._lblActive.Text = "Active: ";
            // 
            // _lblAddresses
            // 
            this._lblAddresses.AutoSize = true;
            this._lblAddresses.Location = new System.Drawing.Point(99, 250);
            this._lblAddresses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblAddresses.Name = "_lblAddresses";
            this._lblAddresses.Size = new System.Drawing.Size(89, 20);
            this._lblAddresses.TabIndex = 8;
            this._lblAddresses.Text = "Addresses";
            // 
            // _btnSaveRecord
            // 
            this._btnSaveRecord.Location = new System.Drawing.Point(258, 498);
            this._btnSaveRecord.Margin = new System.Windows.Forms.Padding(4);
            this._btnSaveRecord.Name = "_btnSaveRecord";
            this._btnSaveRecord.Size = new System.Drawing.Size(200, 42);
            this._btnSaveRecord.TabIndex = 5;
            this._btnSaveRecord.Text = "Save";
            this._btnSaveRecord.UseVisualStyleBackColor = true;
            this._btnSaveRecord.Click += new System.EventHandler(this._btnSaveRecord_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 656);
            this.Controls.Add(this._btnSaveRecord);
            this.Controls.Add(this._lblAddresses);
            this.Controls.Add(this._lblActive);
            this.Controls.Add(this._chkbIsActive);
            this.Controls.Add(this._txtbLastName);
            this.Controls.Add(this._lblLastName);
            this.Controls.Add(this._lstbInformation);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._txtbFirstName);
            this.Controls.Add(this._lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblFirstName;
        private System.Windows.Forms.TextBox _txtbFirstName;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.ListBox _lstbInformation;
        private System.Windows.Forms.Label _lblLastName;
        private System.Windows.Forms.TextBox _txtbLastName;
        private System.Windows.Forms.CheckBox _chkbIsActive;
        private System.Windows.Forms.Label _lblActive;
        private System.Windows.Forms.Label _lblAddresses;
        private System.Windows.Forms.Button _btnSaveRecord;
    }
}

