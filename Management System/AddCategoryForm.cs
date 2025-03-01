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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var userExists = context.Categories.FirstOrDefault(u => u.Name == textBox1.Text);
                    if (userExists != null)
                    {
                        MessageBox.Show("This Category Name already Added. Please Write another Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    var user = new Category
                    {
                        Name = textBox1.Text,
                    };

                    context.Categories.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Category Added successfully!");
                    CategoryForm category = new CategoryForm();
                    category.Show();
                    this.Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CategoryForm category1 = new CategoryForm();
            category1.Show();
            this.Close();
        }
    }
}
