using Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                var user = context.Users.FirstOrDefault(s => s.Email == textBox2.Text && s.Password == textBox3.Text);

                if(textBox2.Text == "admin" && textBox3.Text == "123")
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                    form.FormClosed += (s, args) => this.Close();
                }
                else if (user != null)
                {
                    TasksForm dashboard = new TasksForm(user.Id);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm add = new AddUserForm();
            add.Show();
            this.Hide();
        }
    }
}
