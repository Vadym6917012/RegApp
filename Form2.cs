using RegApp.Repository;

namespace RegApp
{
    public partial class Form2 : Form
    {
        private readonly UserRepository userRepository;

        public Form2()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string name, email, password;

            if (Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text)))
            {
                MessageBox.Show($"You have not filled all the fields");
            }
            else
            {
                name = textBoxRegName.Text;
                email = textBoxRegEmail.Text.ToLower();
                password = textBoxRegPassword.Text;

                var checkEmail = userRepository.Get(email);

                if (checkEmail != null)
                {
                    MessageBox.Show("That email is taken. Try another");
                }
                else
                {
                    userRepository.Add(name, email, password);
                    CleanTextBox();
                    MessageBox.Show("Now, yo`re new user! Please sign in");
                }
            }
        }

        private void CleanTextBox()
        {
            textBoxRegName.Clear();
            textBoxRegEmail.Clear();
            textBoxRegPassword.Clear();
        }

        private void labelNotRegistered_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}