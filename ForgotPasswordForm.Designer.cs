namespace RegApp
{
    partial class ForgotPasswordForm
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
            this.textBoxForgotEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonForgotPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxForgotPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxForgotEmail
            // 
            this.textBoxForgotEmail.Location = new System.Drawing.Point(319, 121);
            this.textBoxForgotEmail.Name = "textBoxForgotEmail";
            this.textBoxForgotEmail.Size = new System.Drawing.Size(235, 27);
            this.textBoxForgotEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // buttonForgotPass
            // 
            this.buttonForgotPass.Location = new System.Drawing.Point(319, 226);
            this.buttonForgotPass.Name = "buttonForgotPass";
            this.buttonForgotPass.Size = new System.Drawing.Size(120, 40);
            this.buttonForgotPass.TabIndex = 2;
            this.buttonForgotPass.Text = "Next";
            this.buttonForgotPass.UseVisualStyleBackColor = true;
            this.buttonForgotPass.Click += new System.EventHandler(this.buttonForgotPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New password";
            // 
            // textBoxForgotPassword
            // 
            this.textBoxForgotPassword.Location = new System.Drawing.Point(319, 169);
            this.textBoxForgotPassword.Name = "textBoxForgotPassword";
            this.textBoxForgotPassword.Size = new System.Drawing.Size(235, 27);
            this.textBoxForgotPassword.TabIndex = 4;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxForgotPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonForgotPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForgotEmail);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxForgotEmail;
        private Label label1;
        private Button buttonForgotPass;
        private Label label2;
        private TextBox textBoxForgotPassword;
    }
}