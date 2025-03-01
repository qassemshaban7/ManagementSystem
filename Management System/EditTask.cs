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
    public partial class EditTask : Form
    {
        private int Id;

        public EditTask(int id)
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

            LoadStudentData();
        }

        private void LoadStudentData()
        {
            using (var context = new DBContext())
            {
                cbPriorit.DataSource = Enum.GetValues(typeof(TaskPriority))
                                           .Cast<TaskPriority>()
                                           .Select(p => new { Value = (int)p, Text = p.ToString() })
                                           .ToList();
                cbPriorit.DisplayMember = "Text";
                cbPriorit.ValueMember = "Value";

                cbStatus.DataSource = Enum.GetValues(typeof(Management_System.Models.TaskStatus))
                                          .Cast<Management_System.Models.TaskStatus>()
                                          .Select(s => new { Value = (int)s, Text = s.ToString() })
                                          .ToList();
                cbStatus.DisplayMember = "Text";
                cbStatus.ValueMember = "Value";

                var categories = context.Categories.Select(d => new { d.Id, d.Name }).ToList();
                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";


                var task = context.TaskItems.FirstOrDefault(s => s.Id == Id);
                if (task != null)
                {
                    tbTitle.Text = task.Title;
                    richTextBox1.Text = task.Description;
                    dateTimePicker1.Value = task.DueDate;

                    cbPriorit.SelectedValue = (int)task.Priority;
                    cbStatus.SelectedValue = (int)task.Status;
                    cbCategory.SelectedValue = task.CategoryId;

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
                    var task = context.TaskItems.FirstOrDefault(s => s.Id == Id);
                    task.Title = tbTitle.Text;
                    task.Description = richTextBox1.Text;
                    task.DueDate = dateTimePicker1.Value;
                    task.Priority = (TaskPriority)cbPriorit.SelectedValue;
                    task.Status = (Management_System.Models.TaskStatus)cbStatus.SelectedValue;
                    task.CategoryId = (int)cbCategory.SelectedValue;

                    context.TaskItems.Update(task);
                    context.SaveChanges();
                    MessageBox.Show("Task Updated Successfully!");
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
    }
}
