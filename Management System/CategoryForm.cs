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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            LoadCategorues();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadCategorues()
        {
            using (var context = new DBContext())
            {
                var Categories = context.Categories.Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                }).ToList();

                dataGridView1.DataSource = Categories;
                dataGridView1.Columns["Id"].Visible = false;
            }

            if (dataGridView1.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(editButton);
            }

            if (dataGridView1.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(deleteButton);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    EditCategoryForm updateForm = new EditCategoryForm(id);
                    updateForm.ShowDialog();
                    LoadCategorues();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    var result = MessageBox.Show($"Do you want to delete this Category?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        DeleteStudent(id);
                }
            }
        }

        private void DeleteStudent(int id)
        {
            using (var context = new DBContext())
            {
                var category = context.Categories.FirstOrDefault(s => s.Id == id);

                context.Categories.Remove(category);
                context.SaveChanges();
                MessageBox.Show("Category Deleted Successfly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategorues();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCategoryForm addUserForm = new AddCategoryForm();
            addUserForm.ShowDialog();

            LoadCategorues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
