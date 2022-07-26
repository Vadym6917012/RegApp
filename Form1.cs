using RegApp.Repository;

namespace RegApp
{
    public partial class Form1 : Form
    {
        private readonly UserRepository userRepository;
        public Form1()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email, password;

            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show($"You have not filled all the fields");
            }
            else
            {
                email = textBoxLoginEmail.Text.ToLower();
                password = textBoxLoginPassword.Text;

                var checkEmail = userRepository.Get(email);
                var checkPassword = userRepository.GetPassword(password);

                if (checkEmail != null)
                {
                    if (checkPassword != null)
                    {
                        MessageBox.Show($"Hello {checkEmail.Name}");
                        CleanTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Wrong password");
                        textBoxLoginPassword.Clear();
                    }
                    
                } else
                {
                    MessageBox.Show("User not found. Please register");
                    CleanTextBox();
                }
            }
        }

        private void CleanTextBox()
        {
            textBoxLoginEmail.Clear();
            textBoxLoginPassword.Clear();
        }

        private void labelNotRegistered_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new ForgotPasswordForm();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}