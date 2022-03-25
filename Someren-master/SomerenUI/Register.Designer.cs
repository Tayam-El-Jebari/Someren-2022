
namespace SomerenUI
{
    partial class FormRegisterScreen
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
            this.labelInstructionsregister = new System.Windows.Forms.Label();
            this.labelUsernameRegister = new System.Windows.Forms.Label();
            this.labelPasswordRegister = new System.Windows.Forms.Label();
            this.labelReenterPassword = new System.Windows.Forms.Label();
            this.textBoxUsernameRegister = new System.Windows.Forms.TextBox();
            this.textBoxPasswordRegister = new System.Windows.Forms.TextBox();
            this.textBoxPasswordReenterRegister = new System.Windows.Forms.TextBox();
            this.labelLicenseKey = new System.Windows.Forms.Label();
            this.textBoxLicenseKey = new System.Windows.Forms.TextBox();
            this.buttonRegisterRegister = new System.Windows.Forms.Button();
            this.buttonBackTologin = new System.Windows.Forms.Button();
            this.labelQuestionRegister = new System.Windows.Forms.Label();
            this.labelAnswerRegister = new System.Windows.Forms.Label();
            this.textBoxQuestionRegister = new System.Windows.Forms.TextBox();
            this.textBoxAnswerRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInstructionsregister
            // 
            this.labelInstructionsregister.AutoSize = true;
            this.labelInstructionsregister.Location = new System.Drawing.Point(55, 70);
            this.labelInstructionsregister.Name = "labelInstructionsregister";
            this.labelInstructionsregister.Size = new System.Drawing.Size(225, 17);
            this.labelInstructionsregister.TabIndex = 15;
            this.labelInstructionsregister.Text = "Please fill in all the requested data";
            // 
            // labelUsernameRegister
            // 
            this.labelUsernameRegister.AutoSize = true;
            this.labelUsernameRegister.Location = new System.Drawing.Point(84, 119);
            this.labelUsernameRegister.Name = "labelUsernameRegister";
            this.labelUsernameRegister.Size = new System.Drawing.Size(122, 17);
            this.labelUsernameRegister.TabIndex = 1;
            this.labelUsernameRegister.Text = "Username / email:";
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.AutoSize = true;
            this.labelPasswordRegister.Location = new System.Drawing.Point(133, 153);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(73, 17);
            this.labelPasswordRegister.TabIndex = 3;
            this.labelPasswordRegister.Text = "Password:";
            // 
            // labelReenterPassword
            // 
            this.labelReenterPassword.AutoSize = true;
            this.labelReenterPassword.Location = new System.Drawing.Point(74, 188);
            this.labelReenterPassword.Name = "labelReenterPassword";
            this.labelReenterPassword.Size = new System.Drawing.Size(132, 17);
            this.labelReenterPassword.TabIndex = 5;
            this.labelReenterPassword.Text = "Re-enter password:";
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(228, 116);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxUsernameRegister.TabIndex = 2;
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(228, 153);
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.PasswordChar = '*';
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxPasswordRegister.TabIndex = 4;
            // 
            // textBoxPasswordReenterRegister
            // 
            this.textBoxPasswordReenterRegister.Location = new System.Drawing.Point(228, 188);
            this.textBoxPasswordReenterRegister.Name = "textBoxPasswordReenterRegister";
            this.textBoxPasswordReenterRegister.PasswordChar = '*';
            this.textBoxPasswordReenterRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxPasswordReenterRegister.TabIndex = 6;
            // 
            // labelLicenseKey
            // 
            this.labelLicenseKey.AutoSize = true;
            this.labelLicenseKey.Location = new System.Drawing.Point(119, 224);
            this.labelLicenseKey.Name = "labelLicenseKey";
            this.labelLicenseKey.Size = new System.Drawing.Size(87, 17);
            this.labelLicenseKey.TabIndex = 7;
            this.labelLicenseKey.Text = "License key:";
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.Location = new System.Drawing.Point(228, 224);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.Size = new System.Drawing.Size(174, 22);
            this.textBoxLicenseKey.TabIndex = 8;
            // 
            // buttonRegisterRegister
            // 
            this.buttonRegisterRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRegisterRegister.Location = new System.Drawing.Point(0, 454);
            this.buttonRegisterRegister.Name = "buttonRegisterRegister";
            this.buttonRegisterRegister.Size = new System.Drawing.Size(551, 46);
            this.buttonRegisterRegister.TabIndex = 13;
            this.buttonRegisterRegister.Text = "Register";
            this.buttonRegisterRegister.UseVisualStyleBackColor = true;
            this.buttonRegisterRegister.Click += new System.EventHandler(this.buttonRegisterRegister_Click);
            // 
            // buttonBackTologin
            // 
            this.buttonBackTologin.Location = new System.Drawing.Point(12, 12);
            this.buttonBackTologin.Name = "buttonBackTologin";
            this.buttonBackTologin.Size = new System.Drawing.Size(126, 39);
            this.buttonBackTologin.TabIndex = 14;
            this.buttonBackTologin.Text = "<- Back";
            this.buttonBackTologin.UseVisualStyleBackColor = true;
            this.buttonBackTologin.Click += new System.EventHandler(this.buttonBackTologin_Click);
            // 
            // labelQuestionRegister
            // 
            this.labelQuestionRegister.AutoSize = true;
            this.labelQuestionRegister.Location = new System.Drawing.Point(137, 264);
            this.labelQuestionRegister.Name = "labelQuestionRegister";
            this.labelQuestionRegister.Size = new System.Drawing.Size(69, 17);
            this.labelQuestionRegister.TabIndex = 9;
            this.labelQuestionRegister.Text = "Question:";
            // 
            // labelAnswerRegister
            // 
            this.labelAnswerRegister.AutoSize = true;
            this.labelAnswerRegister.Location = new System.Drawing.Point(148, 300);
            this.labelAnswerRegister.Name = "labelAnswerRegister";
            this.labelAnswerRegister.Size = new System.Drawing.Size(58, 17);
            this.labelAnswerRegister.TabIndex = 11;
            this.labelAnswerRegister.Text = "Answer:";
            // 
            // textBoxQuestionRegister
            // 
            this.textBoxQuestionRegister.Location = new System.Drawing.Point(228, 264);
            this.textBoxQuestionRegister.Name = "textBoxQuestionRegister";
            this.textBoxQuestionRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxQuestionRegister.TabIndex = 10;
            // 
            // textBoxAnswerRegister
            // 
            this.textBoxAnswerRegister.Location = new System.Drawing.Point(228, 300);
            this.textBoxAnswerRegister.Name = "textBoxAnswerRegister";
            this.textBoxAnswerRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxAnswerRegister.TabIndex = 12;
            // 
            // FormRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 500);
            this.Controls.Add(this.textBoxAnswerRegister);
            this.Controls.Add(this.textBoxQuestionRegister);
            this.Controls.Add(this.labelAnswerRegister);
            this.Controls.Add(this.labelQuestionRegister);
            this.Controls.Add(this.buttonBackTologin);
            this.Controls.Add(this.buttonRegisterRegister);
            this.Controls.Add(this.textBoxLicenseKey);
            this.Controls.Add(this.labelLicenseKey);
            this.Controls.Add(this.textBoxPasswordReenterRegister);
            this.Controls.Add(this.textBoxPasswordRegister);
            this.Controls.Add(this.textBoxUsernameRegister);
            this.Controls.Add(this.labelReenterPassword);
            this.Controls.Add(this.labelPasswordRegister);
            this.Controls.Add(this.labelUsernameRegister);
            this.Controls.Add(this.labelInstructionsregister);
            this.Name = "FormRegisterScreen";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegisterScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInstructionsregister;
        private System.Windows.Forms.Label labelUsernameRegister;
        private System.Windows.Forms.Label labelPasswordRegister;
        private System.Windows.Forms.Label labelReenterPassword;
        private System.Windows.Forms.TextBox textBoxUsernameRegister;
        private System.Windows.Forms.TextBox textBoxPasswordRegister;
        private System.Windows.Forms.TextBox textBoxPasswordReenterRegister;
        private System.Windows.Forms.Label labelLicenseKey;
        private System.Windows.Forms.TextBox textBoxLicenseKey;
        private System.Windows.Forms.Button buttonRegisterRegister;
        private System.Windows.Forms.Button buttonBackTologin;
        private System.Windows.Forms.Label labelQuestionRegister;
        private System.Windows.Forms.Label labelAnswerRegister;
        private System.Windows.Forms.TextBox textBoxQuestionRegister;
        private System.Windows.Forms.TextBox textBoxAnswerRegister;
    }
}