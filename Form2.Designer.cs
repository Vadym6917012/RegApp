namespace RegApp
{
    partial class Form2
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
            this.labelNotRegistered = new System.Windows.Forms.Label();
            this.textBoxRegPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxRegName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNotRegistered
            // 
            this.labelNotRegistered.AutoSize = true;
            this.labelNotRegistered.Location = new System.Drawing.Point(393, 229);
            this.labelNotRegistered.Name = "labelNotRegistered";
            this.labelNotRegistered.Size = new System.Drawing.Size(46, 20);
            this.labelNotRegistered.TabIndex = 11;
            this.labelNotRegistered.Text = "Login";
            this.labelNotRegistered.Click += new System.EventHandler(this.labelNotRegistered_Click);
            // 
            // textBoxRegPassword
            // 
            this.textBoxRegPassword.Location = new System.Drawing.Point(327, 194);
            this.textBoxRegPassword.Name = "textBoxRegPassword";
            this.textBoxRegPassword.Size = new System.Drawing.Size(191, 27);
            this.textBoxRegPassword.TabIndex = 10;
            // 
            // textBoxRegEmail
            // 
            this.textBoxRegEmail.Location = new System.Drawing.Point(327, 149);
            this.textBoxRegEmail.Name = "textBoxRegEmail";
            this.textBoxRegEmail.Size = new System.Drawing.Size(191, 27);
            this.textBoxRegEmail.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email";
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(364, 261);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(107, 41);
            this.buttonReg.TabIndex = 6;
            this.buttonReg.Text = "Register";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxRegName
            // 
            this.textBoxRegName.Location = new System.Drawing.Point(327, 106);
            this.textBoxRegName.Name = "textBoxRegName";
            this.textBoxRegName.Size = new System.Drawing.Size(191, 27);
            this.textBoxRegName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxRegName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNotRegistered);
            this.Controls.Add(this.textBoxRegPassword);
            this.Controls.Add(this.textBoxRegEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReg);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNotRegistered;
        private TextBox textBoxRegPassword;
        private TextBox textBoxRegEmail;
        private Label label2;
        private Label label1;
        private Button buttonReg;
        private TextBox textBoxRegName;
        private Label label3;
    }
}