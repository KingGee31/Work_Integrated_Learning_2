namespace LoginFormApp
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
            this.FormTitleLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passWordLabel = new System.Windows.Forms.Label();
            this.eMailAddressLabel = new System.Windows.Forms.Label();
            this.userNameTextboxLoginForm = new System.Windows.Forms.TextBox();
            this.passWordTextboxLoginForm = new System.Windows.Forms.TextBox();
            this.eMailAddressTextboxLoginForm = new System.Windows.Forms.TextBox();
            this.loginButtonLoginForm = new System.Windows.Forms.Button();
            this.clearButtonLoginForm = new System.Windows.Forms.Button();
            this.navigateToCreateAccountGroupBoxLoginForm = new System.Windows.Forms.GroupBox();
            this.toExitButtonLoginForm = new System.Windows.Forms.Button();
            this.toExitTheProgramLabelLoginForm = new System.Windows.Forms.Label();
            this.toRegisterNewAccountButtonLoginForm = new System.Windows.Forms.Button();
            this.toRegisterNewAccountLabelLoginForm = new System.Windows.Forms.Label();
            this.forgotPasswordCheckBoxForm = new System.Windows.Forms.CheckBox();
            this.forgotPasswordClickButtonForm1 = new System.Windows.Forms.Button();
            this.LoginPictureOfTheApplication = new System.Windows.Forms.PictureBox();
            this.navigateToCreateAccountGroupBoxLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureOfTheApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // FormTitleLabel
            // 
            this.FormTitleLabel.AutoSize = true;
            this.FormTitleLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitleLabel.Location = new System.Drawing.Point(212, 9);
            this.FormTitleLabel.Name = "FormTitleLabel";
            this.FormTitleLabel.Size = new System.Drawing.Size(573, 58);
            this.FormTitleLabel.TabIndex = 0;
            this.FormTitleLabel.Text = "Fleet Tracking Information System";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(217, 251);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(125, 25);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Username:";
            // 
            // passWordLabel
            // 
            this.passWordLabel.AutoSize = true;
            this.passWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordLabel.Location = new System.Drawing.Point(217, 306);
            this.passWordLabel.Name = "passWordLabel";
            this.passWordLabel.Size = new System.Drawing.Size(121, 25);
            this.passWordLabel.TabIndex = 2;
            this.passWordLabel.Text = "Password:";
            // 
            // eMailAddressLabel
            // 
            this.eMailAddressLabel.AutoSize = true;
            this.eMailAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailAddressLabel.Location = new System.Drawing.Point(217, 360);
            this.eMailAddressLabel.Name = "eMailAddressLabel";
            this.eMailAddressLabel.Size = new System.Drawing.Size(177, 25);
            this.eMailAddressLabel.TabIndex = 3;
            this.eMailAddressLabel.Text = "e-Mail Address:";
            // 
            // userNameTextboxLoginForm
            // 
            this.userNameTextboxLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextboxLoginForm.Location = new System.Drawing.Point(400, 257);
            this.userNameTextboxLoginForm.Name = "userNameTextboxLoginForm";
            this.userNameTextboxLoginForm.Size = new System.Drawing.Size(229, 24);
            this.userNameTextboxLoginForm.TabIndex = 4;
            this.userNameTextboxLoginForm.TextChanged += new System.EventHandler(this.userNameTextboxLoginForm_TextChanged);
            // 
            // passWordTextboxLoginForm
            // 
            this.passWordTextboxLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTextboxLoginForm.Location = new System.Drawing.Point(400, 311);
            this.passWordTextboxLoginForm.Name = "passWordTextboxLoginForm";
            this.passWordTextboxLoginForm.Size = new System.Drawing.Size(229, 24);
            this.passWordTextboxLoginForm.TabIndex = 5;
            // 
            // eMailAddressTextboxLoginForm
            // 
            this.eMailAddressTextboxLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMailAddressTextboxLoginForm.Location = new System.Drawing.Point(400, 366);
            this.eMailAddressTextboxLoginForm.Name = "eMailAddressTextboxLoginForm";
            this.eMailAddressTextboxLoginForm.Size = new System.Drawing.Size(229, 24);
            this.eMailAddressTextboxLoginForm.TabIndex = 6;
            this.eMailAddressTextboxLoginForm.TextChanged += new System.EventHandler(this.eMailAddressTextboxLoginForm_TextChanged);
            // 
            // loginButtonLoginForm
            // 
            this.loginButtonLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonLoginForm.Location = new System.Drawing.Point(400, 456);
            this.loginButtonLoginForm.Name = "loginButtonLoginForm";
            this.loginButtonLoginForm.Size = new System.Drawing.Size(129, 27);
            this.loginButtonLoginForm.TabIndex = 8;
            this.loginButtonLoginForm.Text = "Login!";
            this.loginButtonLoginForm.UseVisualStyleBackColor = true;
            this.loginButtonLoginForm.Click += new System.EventHandler(this.loginButtonLoginForm_Click);
            // 
            // clearButtonLoginForm
            // 
            this.clearButtonLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButtonLoginForm.Location = new System.Drawing.Point(535, 456);
            this.clearButtonLoginForm.Name = "clearButtonLoginForm";
            this.clearButtonLoginForm.Size = new System.Drawing.Size(94, 27);
            this.clearButtonLoginForm.TabIndex = 9;
            this.clearButtonLoginForm.Text = "Clear";
            this.clearButtonLoginForm.UseVisualStyleBackColor = true;
            this.clearButtonLoginForm.Click += new System.EventHandler(this.clearButtonLoginForm_Click);
            // 
            // navigateToCreateAccountGroupBoxLoginForm
            // 
            this.navigateToCreateAccountGroupBoxLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navigateToCreateAccountGroupBoxLoginForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navigateToCreateAccountGroupBoxLoginForm.Controls.Add(this.toExitButtonLoginForm);
            this.navigateToCreateAccountGroupBoxLoginForm.Controls.Add(this.toExitTheProgramLabelLoginForm);
            this.navigateToCreateAccountGroupBoxLoginForm.Controls.Add(this.toRegisterNewAccountButtonLoginForm);
            this.navigateToCreateAccountGroupBoxLoginForm.Controls.Add(this.toRegisterNewAccountLabelLoginForm);
            this.navigateToCreateAccountGroupBoxLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigateToCreateAccountGroupBoxLoginForm.Location = new System.Drawing.Point(768, 306);
            this.navigateToCreateAccountGroupBoxLoginForm.Name = "navigateToCreateAccountGroupBoxLoginForm";
            this.navigateToCreateAccountGroupBoxLoginForm.Size = new System.Drawing.Size(306, 215);
            this.navigateToCreateAccountGroupBoxLoginForm.TabIndex = 10;
            this.navigateToCreateAccountGroupBoxLoginForm.TabStop = false;
            this.navigateToCreateAccountGroupBoxLoginForm.Text = "Navigate The App";
            // 
            // toExitButtonLoginForm
            // 
            this.toExitButtonLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toExitButtonLoginForm.Location = new System.Drawing.Point(182, 120);
            this.toExitButtonLoginForm.Name = "toExitButtonLoginForm";
            this.toExitButtonLoginForm.Size = new System.Drawing.Size(118, 23);
            this.toExitButtonLoginForm.TabIndex = 3;
            this.toExitButtonLoginForm.Text = "Click To Exit";
            this.toExitButtonLoginForm.UseVisualStyleBackColor = true;
            this.toExitButtonLoginForm.Click += new System.EventHandler(this.toExitButtonLoginForm_Click);
            // 
            // toExitTheProgramLabelLoginForm
            // 
            this.toExitTheProgramLabelLoginForm.AutoSize = true;
            this.toExitTheProgramLabelLoginForm.Location = new System.Drawing.Point(6, 120);
            this.toExitTheProgramLabelLoginForm.Name = "toExitTheProgramLabelLoginForm";
            this.toExitTheProgramLabelLoginForm.Size = new System.Drawing.Size(170, 20);
            this.toExitTheProgramLabelLoginForm.TabIndex = 2;
            this.toExitTheProgramLabelLoginForm.Text = "To exit the Program ";
            // 
            // toRegisterNewAccountButtonLoginForm
            // 
            this.toRegisterNewAccountButtonLoginForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegisterNewAccountButtonLoginForm.Location = new System.Drawing.Point(225, 58);
            this.toRegisterNewAccountButtonLoginForm.Name = "toRegisterNewAccountButtonLoginForm";
            this.toRegisterNewAccountButtonLoginForm.Size = new System.Drawing.Size(75, 23);
            this.toRegisterNewAccountButtonLoginForm.TabIndex = 1;
            this.toRegisterNewAccountButtonLoginForm.Text = "Click!";
            this.toRegisterNewAccountButtonLoginForm.UseVisualStyleBackColor = true;
            this.toRegisterNewAccountButtonLoginForm.Click += new System.EventHandler(this.toRegisterNewAccountButtonLoginForm_Click);
            // 
            // toRegisterNewAccountLabelLoginForm
            // 
            this.toRegisterNewAccountLabelLoginForm.AutoSize = true;
            this.toRegisterNewAccountLabelLoginForm.Location = new System.Drawing.Point(6, 58);
            this.toRegisterNewAccountLabelLoginForm.Name = "toRegisterNewAccountLabelLoginForm";
            this.toRegisterNewAccountLabelLoginForm.Size = new System.Drawing.Size(212, 20);
            this.toRegisterNewAccountLabelLoginForm.TabIndex = 0;
            this.toRegisterNewAccountLabelLoginForm.Text = "To Register New Account";
            // 
            // forgotPasswordCheckBoxForm
            // 
            this.forgotPasswordCheckBoxForm.AutoSize = true;
            this.forgotPasswordCheckBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordCheckBoxForm.Location = new System.Drawing.Point(400, 409);
            this.forgotPasswordCheckBoxForm.Name = "forgotPasswordCheckBoxForm";
            this.forgotPasswordCheckBoxForm.Size = new System.Drawing.Size(142, 22);
            this.forgotPasswordCheckBoxForm.TabIndex = 12;
            this.forgotPasswordCheckBoxForm.Text = "Forgot Password";
            this.forgotPasswordCheckBoxForm.UseVisualStyleBackColor = true;
            // 
            // forgotPasswordClickButtonForm1
            // 
            this.forgotPasswordClickButtonForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordClickButtonForm1.Location = new System.Drawing.Point(554, 409);
            this.forgotPasswordClickButtonForm1.Name = "forgotPasswordClickButtonForm1";
            this.forgotPasswordClickButtonForm1.Size = new System.Drawing.Size(75, 23);
            this.forgotPasswordClickButtonForm1.TabIndex = 13;
            this.forgotPasswordClickButtonForm1.Text = "Click!";
            this.forgotPasswordClickButtonForm1.UseVisualStyleBackColor = true;
            this.forgotPasswordClickButtonForm1.Click += new System.EventHandler(this.forgotPasswordClickButtonForm1_Click);
            // 
            // LoginPictureOfTheApplication
            // 
            this.LoginPictureOfTheApplication.Location = new System.Drawing.Point(400, 83);
            this.LoginPictureOfTheApplication.Name = "LoginPictureOfTheApplication";
            this.LoginPictureOfTheApplication.Size = new System.Drawing.Size(229, 168);
            this.LoginPictureOfTheApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPictureOfTheApplication.TabIndex = 11;
            this.LoginPictureOfTheApplication.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 533);
            this.Controls.Add(this.forgotPasswordClickButtonForm1);
            this.Controls.Add(this.forgotPasswordCheckBoxForm);
            this.Controls.Add(this.LoginPictureOfTheApplication);
            this.Controls.Add(this.navigateToCreateAccountGroupBoxLoginForm);
            this.Controls.Add(this.clearButtonLoginForm);
            this.Controls.Add(this.loginButtonLoginForm);
            this.Controls.Add(this.eMailAddressTextboxLoginForm);
            this.Controls.Add(this.passWordTextboxLoginForm);
            this.Controls.Add(this.userNameTextboxLoginForm);
            this.Controls.Add(this.eMailAddressLabel);
            this.Controls.Add(this.passWordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.FormTitleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navigateToCreateAccountGroupBoxLoginForm.ResumeLayout(false);
            this.navigateToCreateAccountGroupBoxLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPictureOfTheApplication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormTitleLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passWordLabel;
        private System.Windows.Forms.Label eMailAddressLabel;
        private System.Windows.Forms.TextBox userNameTextboxLoginForm;
        private System.Windows.Forms.TextBox passWordTextboxLoginForm;
        private System.Windows.Forms.TextBox eMailAddressTextboxLoginForm;
        private System.Windows.Forms.Button loginButtonLoginForm;
        private System.Windows.Forms.Button clearButtonLoginForm;
        private System.Windows.Forms.GroupBox navigateToCreateAccountGroupBoxLoginForm;
        private System.Windows.Forms.Button toExitButtonLoginForm;
        private System.Windows.Forms.Label toExitTheProgramLabelLoginForm;
        private System.Windows.Forms.Button toRegisterNewAccountButtonLoginForm;
        private System.Windows.Forms.Label toRegisterNewAccountLabelLoginForm;
        private System.Windows.Forms.PictureBox LoginPictureOfTheApplication;
        private System.Windows.Forms.CheckBox forgotPasswordCheckBoxForm;
        private System.Windows.Forms.Button forgotPasswordClickButtonForm1;
    }
}

