using Management_System.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadUsers();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadUsers()
        {
            using (var context = new DBContext())
            {
                var Users = context.Users.Where(s => s.Email != "admin").Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    Email = s.Email,
                }).ToList();

                dataGridView1.DataSource = Users;
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

                    UpdateUserForm updateForm = new UpdateUserForm(id);
                    updateForm.ShowDialog();
                    LoadUsers();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    var result = MessageBox.Show($"Do you want to delete this User?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        DeleteStudent(id);
                }
            }
        }

        private void DeleteStudent(int id)
        {
            using (var context = new DBContext())
            {
                var student = context.Users.FirstOrDefault(s => s.Id == id);

                context.Users.Remove(student);
                context.SaveChanges();
                MessageBox.Show("User Deleted Successfly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();

            LoadUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                var user = context.Users.Where(s => s.Email == "admin").FirstOrDefault();
                if (user != null)
                {
                    AllTasksForm dashboard1 = new AllTasksForm(user.Id);
                    dashboard1.ShowDialog();
                    this.Hide();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    
    }
}