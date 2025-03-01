using Management_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management_System
{
    public partial class TasksForm : Form
    {
        private int Id;
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 1;

        public TasksForm(int id)
        {
            InitializeComponent();
            Id = id;

            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    EditTask updateForm = new EditTask(id);
                    updateForm.ShowDialog();
                    LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                    var result = MessageBox.Show($"Do you want to delete this Task?", "Ok", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                        DeleteStudent(id);
                }
            }
        }

        private void DeleteStudent(int id)
        {
            using (var context = new DBContext())
            {
                var TaskItem = context.TaskItems.FirstOrDefault(s => s.Id == id);

                context.TaskItems.Remove(TaskItem);
                context.SaveChanges();
                MessageBox.Show("Task Item Deleted Successfly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTasks();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddTask addTask = new AddTask(Id);
            addTask.ShowDialog();

            LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadTasks(comboBox1.SelectedItem.ToString());
            LoadTasks(comboBox2.SelectedItem.ToString());
        }

        private void LoadTasks(string searchQuery = "", string statusFilter = "All", string priorityFilter = "All")
        {
            using (var context = new DBContext())
            {
                var query = context.TaskItems.Where(x => x.UserId == Id);

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query = query.Where(x => x.Title.Contains(searchQuery) || x.Description.Contains(searchQuery));
                }

                if (statusFilter != "All" && priorityFilter != "All")
                {
                    query = query.Where(x => x.Status.ToString() == statusFilter && x.Priority.ToString() == priorityFilter);
                }
                else if (statusFilter != "All")
                {
                    query = query.Where(x => x.Status.ToString() == statusFilter);
                }
                else if (priorityFilter != "All")
                {
                    query = query.Where(x => x.Priority.ToString() == priorityFilter);
                }


                int totalTasks = query.Count();
                totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);


                var TasksItem = query
                .OrderBy(t => t.DueDate)
                .Skip((currentPage - 1) * pageSize)
                .Take(pageSize)
                .Select(s => new
                {
                    Id = s.Id,
                    Title = s.Title,
                    Description = s.Description,
                    DueDate = s.DueDate,
                    Priority = s.Priority,
                    Status = s.Status.ToString(),
                })
                .ToList();

                dataGridView1.DataSource = TasksItem;
                dataGridView1.Columns["Id"].Visible = false;

                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPages;
                label7.Text = $"{currentPage} of {totalPages}";
                label8.Text = $"Number of results: {totalTasks}";
            }

            if (dataGridView1.Columns["Status"] != null)
            {
                dataGridView1.Columns.Remove("Status");
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

            TaskStatusColumn statusColumn = new TaskStatusColumn();
            statusColumn.DataPropertyName = "Status";
            statusColumn.HeaderText = "Task Status";
            dataGridView1.Columns.Insert(5, statusColumn);
        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "All";

            comboBox1.SelectedIndexChanged += (s, e) =>
                LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());

            textBox1.TextChanged += (s, e) =>
                LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());

            comboBox2.SelectedItem = "All";

            comboBox2.SelectedIndexChanged += (s, e) =>
                LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());

            button3.Click += (s, e) => LoadTasksGroupedByPriority();

            LoadTasks();
        }

        private void LoadTasksGroupedByPriority()
        {
            using (var context = new DBContext())
            {
                var statusFilter = comboBox1.SelectedItem.ToString();
                var priorityFilter = comboBox2.SelectedItem.ToString();

                if (statusFilter == "All" && priorityFilter == "All")
                {
                    var tasks = context.TaskItems
                    .Where(x =>
                        (x.Title.Contains(textBox1.Text.Trim()) ||
                        x.Description.Contains(textBox1.Text.Trim()))
                        && x.UserId == Id
                    )
                    .Include(x => x.User)
                    .Select(s => new
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Description = s.Description,
                        DueDate = s.DueDate,
                        Priority = s.Priority,
                        Status = s.Status,
                    })
                    .OrderBy(x => x.Priority)
                    .ThenBy(x => x.DueDate)
                    .ThenBy(x => x.Id)
                    .ToList();

                    var groupedTasks = tasks
                        .GroupBy(t => t.Priority)
                        .SelectMany(g => g)
                        .ToList();

                    int totalTasks = groupedTasks.Count();
                    totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);

                    var TasksItem = groupedTasks
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();


                    dataGridView1.DataSource = TasksItem;
                    dataGridView1.Columns["Id"].Visible = false;

                    btnPrevious.Enabled = currentPage > 1;
                    btnNext.Enabled = currentPage < totalPages;
                    label7.Text = $"{currentPage} of {totalPages}";
                    label8.Text = $"Number of results: {totalTasks}";

                    if (dataGridView1.Columns["Status"] != null)
                    {
                        dataGridView1.Columns.Remove("Status");
                    }

                    TaskStatusColumn statusColumn = new TaskStatusColumn();
                    statusColumn.DataPropertyName = "Status";
                    statusColumn.HeaderText = "Task Status";
                    dataGridView1.Columns.Insert(5, statusColumn);
                }
                else if (statusFilter == "All")
                {
                    var tasks = context.TaskItems
                    .Where(x =>
                        (x.Title.Contains(textBox1.Text.Trim()) ||
                         x.Description.Contains(textBox1.Text.Trim()))
                        && x.Priority.ToString() == priorityFilter
                        && x.UserId == Id
                    )
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Include(x => x.User)
                    .Select(s => new
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Description = s.Description,
                        DueDate = s.DueDate,
                        Priority = s.Priority,
                        Status = s.Status,
                    })
                    .OrderBy(x => x.Priority)
                    .ThenBy(x => x.DueDate)
                    .ThenBy(x => x.Id)
                    .ToList();

                    var groupedTasks = tasks
                        .GroupBy(t => t.Priority)
                        .SelectMany(g => g)
                        .ToList();

                    int totalTasks = groupedTasks.Count();
                    totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);

                    var TasksItem = groupedTasks
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    dataGridView1.DataSource = TasksItem;
                    dataGridView1.Columns["Id"].Visible = false;

                    btnPrevious.Enabled = currentPage > 1;
                    btnNext.Enabled = currentPage < totalPages;
                    label7.Text = $"{currentPage} of {totalPages}";
                    label8.Text = $"Number of results: {totalTasks}";

                    if (dataGridView1.Columns["Status"] != null)
                    {
                        dataGridView1.Columns.Remove("Status");
                    }

                    TaskStatusColumn statusColumn = new TaskStatusColumn();
                    statusColumn.DataPropertyName = "Status";
                    statusColumn.HeaderText = "Task Status";
                    dataGridView1.Columns.Insert(5, statusColumn);
                }
                else if (priorityFilter == "All")
                {
                    var tasks = context.TaskItems
                    .Where(x =>
                        (x.Title.Contains(textBox1.Text.Trim()) ||
                         x.Description.Contains(textBox1.Text.Trim()))
                        && x.Status.ToString() == statusFilter
                        && x.UserId == Id
                    )
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .Include(x => x.User)
                    .Select(s => new
                    {
                        Id = s.Id,
                        Title = s.Title,
                        Description = s.Description,
                        DueDate = s.DueDate,
                        Priority = s.Priority,
                        Status = s.Status,
                    })
                    .OrderBy(t => t.Priority)
                    .ThenBy(t => t.DueDate)
                    .ThenBy(t => t.Id)
                    .ToList();

                    var groupedTasks = tasks
                        .GroupBy(t => t.Priority)
                        .SelectMany(g => g)
                        .ToList();

                    int totalTasks = groupedTasks.Count();
                    totalPages = (int)Math.Ceiling((double)totalTasks / pageSize);

                    var TasksItem = groupedTasks
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .ToList();

                    dataGridView1.DataSource = TasksItem;
                    dataGridView1.Columns["Id"].Visible = false;

                    btnPrevious.Enabled = currentPage > 1;
                    btnNext.Enabled = currentPage < totalPages;
                    label7.Text = $"{currentPage} of {totalPages}";
                    label8.Text = $"Number of results: {totalTasks}";

                    if (dataGridView1.Columns["Status"] != null)
                    {
                        dataGridView1.Columns.Remove("Status");
                    }

                    TaskStatusColumn statusColumn = new TaskStatusColumn();
                    statusColumn.DataPropertyName = "Status";
                    statusColumn.HeaderText = "Task Status";
                    dataGridView1.Columns.Insert(5, statusColumn);
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTasks(textBox1.Text.Trim(), comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(Id);
            reportsForm.Show();
            this.Hide();
        }

        ///private void LoadTasks(string statusFilter = "All")
        //{
        //    using (var context = new DBContext())
        //    {
        //        var query = context.TaskItems.Where(x => x.UserId == Id);

        //        if (statusFilter != "All")
        //        {
        //            Management_System.Models.TaskStatus selectedStatus;
        //            if (Enum.TryParse(statusFilter, out selectedStatus))
        //            {
        //                query = query.Where(x => x.Status == selectedStatus);
        //            }
        //        }

        //        var TasksItem = query.Select(s => new
        //        {
        //            Id = s.Id,
        //            Title = s.Title,
        //            DueDate = s.DueDate,
        //            Priority = s.Priority,
        //            Status = s.Status,
        //        }).OrderBy(t => t.DueDate).ToList();

        //        dataGridView1.DataSource = TasksItem;
        //        dataGridView1.Columns["Id"].Visible = false;
        //    }
        //}

    }
}