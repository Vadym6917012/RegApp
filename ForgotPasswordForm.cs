using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegApp.Repository;

namespace RegApp
{
    public partial class ForgotPasswordForm : Form
    {
        private readonly UserRepository userRepository;
        public ForgotPasswordForm()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void buttonForgotPass_Click(object sender, EventArgs e)
        {
            string email, newPassword;

            if (Controls.OfType<TextBox>().Any(x => String.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show($"You have not filled all the fields");
            } else
            {
                email = textBoxForgotEmail.Text.ToLower();
                newPassword = textBoxForgotPassword.Text;

                var checkEmail = userRepository.Get(email);

                if (checkEmail != null)
                {
                    userRepository.UpdatePassword(checkEmail.Password, newPassword);
                    MessageBox.Show("Password changed");
                    
                } else
                {
                    MessageBox.Show("User not found. Please register");
                    
                }
            }
            CleanTextBox();
        }

        private void CleanTextBox()
        {
            textBoxForgotEmail.Clear();
            textBoxForgotPassword.Clear();
        }
    }
}
