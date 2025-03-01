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
    public partial class AddTask : Form
    {
        private int Id;
        public AddTask(int id)
        {
            InitializeComponent();

            Id = id;

            using (var context = new DBContext())
            {
                cbPriorit.DataSource = Enum.GetValues(typeof(TaskPriority));

                cbStatus.DataSource = Enum.GetValues(typeof(Management_System.Models.TaskStatus));


                cbCategory.DataSource = context.Categories.ToList();
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var context = new DBContext())
                {
                    var task = new TaskItem
                    {
                        Title = tbTitle.Text,
                        Description = richTextBox1.Text,
                        DueDate = dateTimePicker1.Value,
                        Priority = (TaskPriority)cbPriorit.SelectedValue,
                        Status = (Management_System.Models.TaskStatus)cbPriorit.SelectedValue,
                        CategoryId = (int)cbCategory.SelectedValue,

                        UserId = Id
                    };

                    context.TaskItems.Add(task);
                    context.SaveChanges();
                    MessageBox.Show("Task Added Successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}