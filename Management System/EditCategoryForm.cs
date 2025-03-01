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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management_System
{
    public partial class EditCategoryForm : Form
    {
        private int Id;

        public EditCategoryForm(int id)
        {
            InitializeComponent();
            Id = id;
            LoadStudentData();
        }
        
        private void LoadStudentData()
        {
            using (var context = new DBContext())
            {
                var user = context.Categories.FirstOrDefault(s => s.Id == Id);
                if (user != null)
                {
                    textBox1.Text = user.Name;
                }
                else
                {
                    this.Close();
                    return;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var user = context.Categories.FirstOrDefault(s => s.Id == Id);
                    user.Name = textBox1.Text;

                    context.Categories.Update(user);
                    context.SaveChanges();
                    MessageBox.Show("Category Updated Successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
