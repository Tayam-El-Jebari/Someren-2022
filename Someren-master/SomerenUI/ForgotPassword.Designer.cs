
namespace SomerenUI
{
    partial class ForgotPasswordScreen
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
            this.textBoxAnswerForgotPassword = new System.Windows.Forms.TextBox();
            this.labelAnswerRegister = new System.Windows.Forms.Label();
            this.labelQuestionRegister = new System.Windows.Forms.Label();
            this.labelDisplayQuestion = new System.Windows.Forms.Label();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.textBoxUsernameForgotPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNewPassword = new System.Windows.Forms.Button();
            this.buttonCodeForgotPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAnswerForgotPassword
            // 
            this.textBoxAnswerForgotPassword.Location = new System.Drawing.Point(203, 266);
            this.textBoxAnswerForgotPassword.Name = "textBoxAnswerForgotPassword";
            this.textBoxAnswerForgotPassword.Size = new System.Drawing.Size(174, 22);
            this.textBoxAnswerForgotPassword.TabIndex = 16;
            // 
            // labelAnswerRegister
            // 
            this.labelAnswerRegister.AutoSize = true;
            this.labelAnswerRegister.Location = new System.Drawing.Point(74, 266);
            this.labelAnswerRegister.Name = "labelAnswerRegister";
            this.labelAnswerRegister.Size = new System.Drawing.Size(58, 17);
            this.labelAnswerRegister.TabIndex = 15;
            this.labelAnswerRegister.Text = "Answer:";
            // 
            // labelQuestionRegister
            // 
            this.labelQuestionRegister.AutoSize = true;
            this.labelQuestionRegister.Location = new System.Drawing.Point(74, 230);
            this.labelQuestionRegister.Name = "labelQuestionRegister";
            this.labelQuestionRegister.Size = new System.Drawing.Size(69, 17);
            this.labelQuestionRegister.TabIndex = 13;
            this.labelQuestionRegister.Text = "Question:";
            // 
            // labelDisplayQuestion
            // 
            this.labelDisplayQuestion.AutoSize = true;
            this.labelDisplayQuestion.Location = new System.Drawing.Point(200, 230);
            this.labelDisplayQuestion.Name = "labelDisplayQuestion";
            this.labelDisplayQuestion.Size = new System.Drawing.Size(65, 17);
            this.labelDisplayQuestion.TabIndex = 17;
            this.labelDisplayQuestion.Text = "Question";
            // 
            // labelInstruction
            // 
            this.labelInstruction.AutoSize = true;
            this.labelInstruction.Location = new System.Drawing.Point(68, 25);
            this.labelInstruction.Name = "labelInstruction";
            this.labelInstruction.Size = new System.Drawing.Size(73, 17);
            this.labelInstruction.TabIndex = 18;
            this.labelInstruction.Text = "Instruction";
            // 
            // textBoxUsernameForgotPassword
            // 
            this.textBoxUsernameForgotPassword.Location = new System.Drawing.Point(203, 186);
            this.textBoxUsernameForgotPassword.Name = "textBoxUsernameForgotPassword";
            this.textBoxUsernameForgotPassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxUsernameForgotPassword.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username: ";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(203, 225);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxNewPassword.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enter a new password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(203, 268);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(159, 22);
            this.textBoxConfirmPassword.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Confirm new password";
            // 
            // buttonNewPassword
            // 
            this.buttonNewPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonNewPassword.Location = new System.Drawing.Point(0, 404);
            this.buttonNewPassword.Name = "buttonNewPassword";
            this.buttonNewPassword.Size = new System.Drawing.Size(438, 46);
            this.buttonNewPassword.TabIndex = 25;
            this.buttonNewPassword.Text = "Enter new password";
            this.buttonNewPassword.UseVisualStyleBackColor = true;
            this.buttonNewPassword.Click += new System.EventHandler(this.buttonNewPassword_Click);
            // 
            // buttonCodeForgotPassword
            // 
            this.buttonCodeForgotPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCodeForgotPassword.Location = new System.Drawing.Point(0, 358);
            this.buttonCodeForgotPassword.Name = "buttonCodeForgotPassword";
            this.buttonCodeForgotPassword.Size = new System.Drawing.Size(438, 46);
            this.buttonCodeForgotPassword.TabIndex = 26;
            this.buttonCodeForgotPassword.Text = "Enter code";
            this.buttonCodeForgotPassword.UseVisualStyleBackColor = true;
            this.buttonCodeForgotPassword.Click += new System.EventHandler(this.buttonCodeForgotPassword_Click);
            // 
            // ForgotPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.buttonCodeForgotPassword);
            this.Controls.Add(this.buttonNewPassword);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsernameForgotPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInstruction);
            this.Controls.Add(this.labelDisplayQuestion);
            this.Controls.Add(this.textBoxAnswerForgotPassword);
            this.Controls.Add(this.labelAnswerRegister);
            this.Controls.Add(this.labelQuestionRegister);
            this.Name = "ForgotPasswordScreen";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnswerForgotPassword;
        private System.Windows.Forms.Label labelAnswerRegister;
        private System.Windows.Forms.Label labelQuestionRegister;
        private System.Windows.Forms.Label labelDisplayQuestion;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.TextBox textBoxUsernameForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNewPassword;
        private System.Windows.Forms.Button buttonCodeForgotPassword;
    }
}