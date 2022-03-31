
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstnameRegister = new System.Windows.Forms.TextBox();
            this.textBoxLastnameRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelInstructionsregister
            // 
            this.labelInstructionsregister.AutoSize = true;
            this.labelInstructionsregister.Location = new System.Drawing.Point(55, 70);
            this.labelInstructionsregister.Name = "labelInstructionsregister";
            this.labelInstructionsregister.Size = new System.Drawing.Size(225, 17);
            this.labelInstructionsregister.TabIndex = 11;
            this.labelInstructionsregister.Text = "Please fill in all the requested data";
            // 
            // labelUsernameRegister
            // 
            this.labelUsernameRegister.AutoSize = true;
            this.labelUsernameRegister.Location = new System.Drawing.Point(160, 187);
            this.labelUsernameRegister.Name = "labelUsernameRegister";
            this.labelUsernameRegister.Size = new System.Drawing.Size(46, 17);
            this.labelUsernameRegister.TabIndex = 14;
            this.labelUsernameRegister.Text = "Email:";
            // 
            // labelPasswordRegister
            // 
            this.labelPasswordRegister.AutoSize = true;
            this.labelPasswordRegister.Location = new System.Drawing.Point(137, 220);
            this.labelPasswordRegister.Name = "labelPasswordRegister";
            this.labelPasswordRegister.Size = new System.Drawing.Size(73, 17);
            this.labelPasswordRegister.TabIndex = 15;
            this.labelPasswordRegister.Text = "Password:";
            // 
            // labelReenterPassword
            // 
            this.labelReenterPassword.AutoSize = true;
            this.labelReenterPassword.Location = new System.Drawing.Point(74, 257);
            this.labelReenterPassword.Name = "labelReenterPassword";
            this.labelReenterPassword.Size = new System.Drawing.Size(132, 17);
            this.labelReenterPassword.TabIndex = 16;
            this.labelReenterPassword.Text = "Re-enter password:";
            // 
            // textBoxUsernameRegister
            // 
            this.textBoxUsernameRegister.Location = new System.Drawing.Point(228, 187);
            this.textBoxUsernameRegister.Name = "textBoxUsernameRegister";
            this.textBoxUsernameRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxUsernameRegister.TabIndex = 3;
            // 
            // textBoxPasswordRegister
            // 
            this.textBoxPasswordRegister.Location = new System.Drawing.Point(228, 220);
            this.textBoxPasswordRegister.Name = "textBoxPasswordRegister";
            this.textBoxPasswordRegister.PasswordChar = '*';
            this.textBoxPasswordRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxPasswordRegister.TabIndex = 4;
            // 
            // textBoxPasswordReenterRegister
            // 
            this.textBoxPasswordReenterRegister.Location = new System.Drawing.Point(228, 257);
            this.textBoxPasswordReenterRegister.Name = "textBoxPasswordReenterRegister";
            this.textBoxPasswordReenterRegister.PasswordChar = '*';
            this.textBoxPasswordReenterRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxPasswordReenterRegister.TabIndex = 5;
            // 
            // labelLicenseKey
            // 
            this.labelLicenseKey.AutoSize = true;
            this.labelLicenseKey.Location = new System.Drawing.Point(119, 293);
            this.labelLicenseKey.Name = "labelLicenseKey";
            this.labelLicenseKey.Size = new System.Drawing.Size(87, 17);
            this.labelLicenseKey.TabIndex = 17;
            this.labelLicenseKey.Text = "License key:";
            // 
            // textBoxLicenseKey
            // 
            this.textBoxLicenseKey.Location = new System.Drawing.Point(228, 290);
            this.textBoxLicenseKey.Name = "textBoxLicenseKey";
            this.textBoxLicenseKey.Size = new System.Drawing.Size(174, 22);
            this.textBoxLicenseKey.TabIndex = 6;
            // 
            // buttonRegisterRegister
            // 
            this.buttonRegisterRegister.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonRegisterRegister.Location = new System.Drawing.Point(0, 454);
            this.buttonRegisterRegister.Name = "buttonRegisterRegister";
            this.buttonRegisterRegister.Size = new System.Drawing.Size(551, 46);
            this.buttonRegisterRegister.TabIndex = 9;
            this.buttonRegisterRegister.Text = "Register";
            this.buttonRegisterRegister.UseVisualStyleBackColor = true;
            this.buttonRegisterRegister.Click += new System.EventHandler(this.buttonRegisterRegister_Click);
            // 
            // buttonBackTologin
            // 
            this.buttonBackTologin.Location = new System.Drawing.Point(12, 12);
            this.buttonBackTologin.Name = "buttonBackTologin";
            this.buttonBackTologin.Size = new System.Drawing.Size(126, 39);
            this.buttonBackTologin.TabIndex = 10;
            this.buttonBackTologin.Text = "<- Back";
            this.buttonBackTologin.UseVisualStyleBackColor = true;
            this.buttonBackTologin.Click += new System.EventHandler(this.buttonBackTologin_Click);
            // 
            // labelQuestionRegister
            // 
            this.labelQuestionRegister.AutoSize = true;
            this.labelQuestionRegister.Location = new System.Drawing.Point(137, 323);
            this.labelQuestionRegister.Name = "labelQuestionRegister";
            this.labelQuestionRegister.Size = new System.Drawing.Size(69, 17);
            this.labelQuestionRegister.TabIndex = 18;
            this.labelQuestionRegister.Text = "Question:";
            // 
            // labelAnswerRegister
            // 
            this.labelAnswerRegister.AutoSize = true;
            this.labelAnswerRegister.Location = new System.Drawing.Point(148, 358);
            this.labelAnswerRegister.Name = "labelAnswerRegister";
            this.labelAnswerRegister.Size = new System.Drawing.Size(58, 17);
            this.labelAnswerRegister.TabIndex = 19;
            this.labelAnswerRegister.Text = "Answer:";
            // 
            // textBoxQuestionRegister
            // 
            this.textBoxQuestionRegister.Location = new System.Drawing.Point(228, 323);
            this.textBoxQuestionRegister.Name = "textBoxQuestionRegister";
            this.textBoxQuestionRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxQuestionRegister.TabIndex = 7;
            // 
            // textBoxAnswerRegister
            // 
            this.textBoxAnswerRegister.Location = new System.Drawing.Point(228, 358);
            this.textBoxAnswerRegister.Name = "textBoxAnswerRegister";
            this.textBoxAnswerRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxAnswerRegister.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lastname:";
            // 
            // textBoxFirstnameRegister
            // 
            this.textBoxFirstnameRegister.Location = new System.Drawing.Point(228, 121);
            this.textBoxFirstnameRegister.Name = "textBoxFirstnameRegister";
            this.textBoxFirstnameRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxFirstnameRegister.TabIndex = 1;
            // 
            // textBoxLastnameRegister
            // 
            this.textBoxLastnameRegister.Location = new System.Drawing.Point(228, 152);
            this.textBoxLastnameRegister.Name = "textBoxLastnameRegister";
            this.textBoxLastnameRegister.Size = new System.Drawing.Size(174, 22);
            this.textBoxLastnameRegister.TabIndex = 2;
            // 
            // FormRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 500);
            this.Controls.Add(this.textBoxLastnameRegister);
            this.Controls.Add(this.textBoxFirstnameRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstnameRegister;
        private System.Windows.Forms.TextBox textBoxLastnameRegister;
    }
}