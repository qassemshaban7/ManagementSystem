using System;
using System.Linq;
using System.Windows.Forms;
using Management_System.Models;

namespace Management_System
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var userExists = context.Users.FirstOrDefault(u => u.Email == textBox2.Text);
                    if (userExists != null)
                    {
                        MessageBox.Show("This email is already in use. Please use another email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var user = new User
                    {
                        Name = textBox1.Text,
                        Email = textBox2.Text,
                        Password = textBox3.Text
                    };

                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Registration completed successfully! You can now log in.");
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
