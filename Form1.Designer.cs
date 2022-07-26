namespace RegApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginEmail = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelNotRegistered = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(341, 265);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 41);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // textBoxLoginEmail
            // 
            this.textBoxLoginEmail.Location = new System.Drawing.Point(304, 153);
            this.textBoxLoginEmail.Name = "textBoxLoginEmail";
            this.textBoxLoginEmail.Size = new System.Drawing.Size(191, 27);
            this.textBoxLoginEmail.TabIndex = 3;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(304, 198);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(191, 27);
            this.textBoxLoginPassword.TabIndex = 4;
            // 
            // labelNotRegistered
            // 
            this.labelNotRegistered.AutoSize = true;
            this.labelNotRegistered.Location = new System.Drawing.Point(271, 233);
            this.labelNotRegistered.Name = "labelNotRegistered";
            this.labelNotRegistered.Size = new System.Drawing.Size(136, 20);
            this.labelNotRegistered.TabIndex = 5;
            this.labelNotRegistered.Text = "Not registered yet?";
            this.labelNotRegistered.Click += new System.EventHandler(this.labelNotRegistered_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forgot password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNotRegistered);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLoginEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private Label label2;
        private TextBox textBoxLoginEmail;
        private TextBox textBoxLoginPassword;
        private Label labelNotRegistered;
        private Label label3;
    }
}