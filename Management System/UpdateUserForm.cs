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
    public partial class UpdateUserForm : Form
    {
        private int Id;

        public UpdateUserForm(int id)
        {
            InitializeComponent();
            Id = id;
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (var context = new DBContext())
            {
                var user = context.Users.FirstOrDefault(s => s.Id == Id);
                if (user != null)
                {
                    textBox1.Text = user.Name;
                    textBox2.Text = user.Email;
                    textBox3.Text = user.Password;
                }
                else
                {
                    this.Close();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var user = context.Users.FirstOrDefault(s => s.Id == Id);
                    user.Name = textBox1.Text;
                    user.Email = textBox2.Text;
                    user.Password = textBox3.Text;

                    context.Users.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("User Updated Successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
