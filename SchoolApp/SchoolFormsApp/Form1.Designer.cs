namespace SchoolFormsApp
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.twitterLabel = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTwitter = new System.Windows.Forms.TextBox();
            this.btnPushToTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "School Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(13, 41);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 13);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "School Address";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(13, 69);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(60, 13);
            this.cityLabel.TabIndex = 2;
            this.cityLabel.Text = "School City";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(13, 96);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(68, 13);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "School State";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(13, 122);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(58, 13);
            this.zipLabel.TabIndex = 4;
            this.zipLabel.Text = "School Zip";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(13, 148);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(74, 13);
            this.phoneLabel.TabIndex = 5;
            this.phoneLabel.Text = "School Phone";
            // 
            // twitterLabel
            // 
            this.twitterLabel.AutoSize = true;
            this.twitterLabel.Location = new System.Drawing.Point(13, 173);
            this.twitterLabel.Name = "twitterLabel";
            this.twitterLabel.Size = new System.Drawing.Size(75, 13);
            this.twitterLabel.TabIndex = 6;
            this.twitterLabel.Text = "School Twitter";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(100, 10);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 7;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(100, 38);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 20);
            this.textAddress.TabIndex = 8;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(100, 66);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 9;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(100, 93);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(100, 20);
            this.textState.TabIndex = 10;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(100, 119);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(100, 20);
            this.textZip.TabIndex = 11;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(100, 145);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 12;
            // 
            // textTwitter
            // 
            this.textTwitter.Location = new System.Drawing.Point(100, 170);
            this.textTwitter.Name = "textTwitter";
            this.textTwitter.Size = new System.Drawing.Size(100, 20);
            this.textTwitter.TabIndex = 13;
            // 
            // btnPushToTest
            // 
            this.btnPushToTest.Location = new System.Drawing.Point(100, 265);
            this.btnPushToTest.Name = "btnPushToTest";
            this.btnPushToTest.Size = new System.Drawing.Size(100, 23);
            this.btnPushToTest.TabIndex = 14;
            this.btnPushToTest.Text = "Push To Test";
            this.btnPushToTest.UseVisualStyleBackColor = true;
            this.btnPushToTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btnPushToTest);
            this.Controls.Add(this.textTwitter);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.twitterLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label twitterLabel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textState;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textTwitter;
        private System.Windows.Forms.Button btnPushToTest;
    }
}

