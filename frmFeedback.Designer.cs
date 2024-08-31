namespace MyFirstWinForm
{
    partial class frmFeedback
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbRate = new System.Windows.Forms.GroupBox();
            this.rbBad = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbGood = new System.Windows.Forms.RadioButton();
            this.rbExcellent = new System.Windows.Forms.RadioButton();
            this.gbLikedFeatures = new System.Windows.Forms.GroupBox();
            this.chkUserFriendly = new System.Windows.Forms.CheckBox();
            this.chkSecurity = new System.Windows.Forms.CheckBox();
            this.chkDesign = new System.Windows.Forms.CheckBox();
            this.chkCalculatorPerformance = new System.Windows.Forms.CheckBox();
            this.gbRate.SuspendLayout();
            this.gbLikedFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(143, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Rate This Calculator";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(257, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatAppearance.BorderSize = 2;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(174, 298);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 31);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbRate
            // 
            this.gbRate.Controls.Add(this.rbBad);
            this.gbRate.Controls.Add(this.rbNormal);
            this.gbRate.Controls.Add(this.rbGood);
            this.gbRate.Controls.Add(this.rbExcellent);
            this.gbRate.Location = new System.Drawing.Point(189, 51);
            this.gbRate.Name = "gbRate";
            this.gbRate.Size = new System.Drawing.Size(130, 121);
            this.gbRate.TabIndex = 6;
            this.gbRate.TabStop = false;
            this.gbRate.Text = "Rate The Application";
            // 
            // rbBad
            // 
            this.rbBad.AutoSize = true;
            this.rbBad.Location = new System.Drawing.Point(16, 88);
            this.rbBad.Name = "rbBad";
            this.rbBad.Size = new System.Drawing.Size(44, 17);
            this.rbBad.TabIndex = 10;
            this.rbBad.TabStop = true;
            this.rbBad.Text = "Bad";
            this.rbBad.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(16, 65);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 9;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbGood
            // 
            this.rbGood.AutoSize = true;
            this.rbGood.Location = new System.Drawing.Point(16, 42);
            this.rbGood.Name = "rbGood";
            this.rbGood.Size = new System.Drawing.Size(51, 17);
            this.rbGood.TabIndex = 8;
            this.rbGood.TabStop = true;
            this.rbGood.Text = "Good";
            this.rbGood.UseVisualStyleBackColor = true;
            // 
            // rbExcellent
            // 
            this.rbExcellent.AutoSize = true;
            this.rbExcellent.Location = new System.Drawing.Point(16, 19);
            this.rbExcellent.Name = "rbExcellent";
            this.rbExcellent.Size = new System.Drawing.Size(68, 17);
            this.rbExcellent.TabIndex = 7;
            this.rbExcellent.TabStop = true;
            this.rbExcellent.Text = "Excellent";
            this.rbExcellent.UseVisualStyleBackColor = true;
            // 
            // gbLikedFeatures
            // 
            this.gbLikedFeatures.Controls.Add(this.chkUserFriendly);
            this.gbLikedFeatures.Controls.Add(this.chkSecurity);
            this.gbLikedFeatures.Controls.Add(this.chkDesign);
            this.gbLikedFeatures.Controls.Add(this.chkCalculatorPerformance);
            this.gbLikedFeatures.Location = new System.Drawing.Point(144, 178);
            this.gbLikedFeatures.Name = "gbLikedFeatures";
            this.gbLikedFeatures.Size = new System.Drawing.Size(221, 114);
            this.gbLikedFeatures.TabIndex = 7;
            this.gbLikedFeatures.TabStop = false;
            this.gbLikedFeatures.Text = "What Features You Liked The Most?";
            // 
            // chkUserFriendly
            // 
            this.chkUserFriendly.AutoSize = true;
            this.chkUserFriendly.Location = new System.Drawing.Point(16, 83);
            this.chkUserFriendly.Name = "chkUserFriendly";
            this.chkUserFriendly.Size = new System.Drawing.Size(87, 17);
            this.chkUserFriendly.TabIndex = 3;
            this.chkUserFriendly.Text = "User-Friendly";
            this.chkUserFriendly.UseVisualStyleBackColor = true;
            // 
            // chkSecurity
            // 
            this.chkSecurity.AutoSize = true;
            this.chkSecurity.Location = new System.Drawing.Point(16, 62);
            this.chkSecurity.Name = "chkSecurity";
            this.chkSecurity.Size = new System.Drawing.Size(64, 17);
            this.chkSecurity.TabIndex = 2;
            this.chkSecurity.Text = "Security";
            this.chkSecurity.UseVisualStyleBackColor = true;
            // 
            // chkDesign
            // 
            this.chkDesign.AutoSize = true;
            this.chkDesign.Location = new System.Drawing.Point(16, 41);
            this.chkDesign.Name = "chkDesign";
            this.chkDesign.Size = new System.Drawing.Size(59, 17);
            this.chkDesign.TabIndex = 1;
            this.chkDesign.Text = "Design";
            this.chkDesign.UseVisualStyleBackColor = true;
            // 
            // chkCalculatorPerformance
            // 
            this.chkCalculatorPerformance.AutoSize = true;
            this.chkCalculatorPerformance.Location = new System.Drawing.Point(16, 20);
            this.chkCalculatorPerformance.Name = "chkCalculatorPerformance";
            this.chkCalculatorPerformance.Size = new System.Drawing.Size(136, 17);
            this.chkCalculatorPerformance.TabIndex = 0;
            this.chkCalculatorPerformance.Text = "Calculator Performance";
            this.chkCalculatorPerformance.UseVisualStyleBackColor = true;
            // 
            // frmFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(508, 341);
            this.Controls.Add(this.gbLikedFeatures);
            this.Controls.Add(this.gbRate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback";
            this.gbRate.ResumeLayout(false);
            this.gbRate.PerformLayout();
            this.gbLikedFeatures.ResumeLayout(false);
            this.gbLikedFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbRate;
        private System.Windows.Forms.RadioButton rbGood;
        private System.Windows.Forms.RadioButton rbExcellent;
        private System.Windows.Forms.GroupBox gbLikedFeatures;
        private System.Windows.Forms.CheckBox chkSecurity;
        private System.Windows.Forms.CheckBox chkDesign;
        private System.Windows.Forms.CheckBox chkCalculatorPerformance;
        private System.Windows.Forms.CheckBox chkUserFriendly;
        private System.Windows.Forms.RadioButton rbBad;
        private System.Windows.Forms.RadioButton rbNormal;
    }
}