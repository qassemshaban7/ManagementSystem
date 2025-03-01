using Management_System.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Charts;
using Microsoft.EntityFrameworkCore;

namespace Management_System
{
    public partial class ReportsForm : Form
    {
        private int Id;
        public ReportsForm(int id)
        {
            InitializeComponent();

            Id = id;
            LoadReportData();
        }

        private void LoadReportData()
        {
            using (var context = new DBContext())
            {
                var user = context.Users.Find(Id);

                if(user.Email == "admin")
                {
                    int pendingTasks = context.TaskItems.Count(t => t.Status == Management_System.Models.TaskStatus.Pending);
                    int inProgressTasks = context.TaskItems.Count(t => t.Status == Management_System.Models.TaskStatus.InProgress);
                    int completedTasks = context.TaskItems.Count(t => t.Status == Management_System.Models.TaskStatus.Completed);

                    int totalTasks = pendingTasks + inProgressTasks + completedTasks;
                    if (totalTasks == 0) totalTasks = 1;

                    lblPendingCount.Text = $"Pending Tasks: {pendingTasks}";
                    lblInProgressCount.Text = $"In Progress Tasks: {inProgressTasks}";
                    lblCompletedCount.Text = $"Completed Tasks: {completedTasks}";

                    var completedTaskTimes = context.TaskItems
                        .Where(t => t.Status == Management_System.Models.TaskStatus.Completed)
                        .Select(t => EF.Functions.DateDiffMinute(t.CreatedAt, t.DueDate))
                        .ToList();

                    double averageCompletionTimeMinutes = completedTaskTimes.Any() ? completedTaskTimes.Average() : 0;

                    int totalMinutes = (int)Math.Round(averageCompletionTimeMinutes);
                    int days = totalMinutes / 1440;
                    int hours = (totalMinutes % 1440) / 60;
                    int minutes = totalMinutes % 60;

                    lblAvgCompletionTime.Text = $"Average Completion Time: {days} days, {hours} hours, {minutes} minutes";

                    var pieChart = new LiveCharts.WinForms.PieChart
                    {
                        Size = new Size(300, 300),
                        Location = new Point((this.ClientSize.Width - 300) / 2, (this.ClientSize.Height - 300) / 2),
                        Anchor = AnchorStyles.None
                    };

                    pieChart.Series = new SeriesCollection
                    {
                        new PieSeries
                        {
                            Title = "Pending",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(pendingTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"Pending: {pendingTasks}"
                        },
                        new PieSeries
                        {
                            Title = "In Progress",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(inProgressTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"In Progress: {inProgressTasks}"
                        },
                        new PieSeries
                        {
                            Title = "Completed",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(completedTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"Completed: {completedTasks}"
                        }
                    };

                    pieChart.DataTooltip = new DefaultTooltip();
                    pieChart.DisableAnimations = false;

                    this.Controls.Add(pieChart);
                }
                else
                {
                    int pendingTasks = context.TaskItems.Where(x => x.UserId == Id).Count(t => t.Status == Management_System.Models.TaskStatus.Pending);
                    int inProgressTasks = context.TaskItems.Where(x => x.UserId == Id).Count(t => t.Status == Management_System.Models.TaskStatus.InProgress);
                    int completedTasks = context.TaskItems.Where(x => x.UserId == Id).Count(t => t.Status == Management_System.Models.TaskStatus.Completed);

                    int totalTasks = pendingTasks + inProgressTasks + completedTasks;
                    if (totalTasks == 0) totalTasks = 1;

                    lblPendingCount.Text = $"Pending Tasks: {pendingTasks}";
                    lblInProgressCount.Text = $"In Progress Tasks: {inProgressTasks}";
                    lblCompletedCount.Text = $"Completed Tasks: {completedTasks}";

                    var completedTaskTimes = context.TaskItems
                        .Where(t => t.UserId == Id && t.Status == Management_System.Models.TaskStatus.Completed)
                        .Select(t => EF.Functions.DateDiffMinute(t.CreatedAt, t.DueDate))
                        .ToList();

                    double averageCompletionTimeMinutes = completedTaskTimes.Any() ? completedTaskTimes.Average() : 0;

                    int totalMinutes = (int)Math.Round(averageCompletionTimeMinutes);
                    int days = totalMinutes / 1440;
                    int hours = (totalMinutes % 1440) / 60;
                    int minutes = totalMinutes % 60;

                    lblAvgCompletionTime.Text = $"Average Completion Time: {days} days, {hours} hours, {minutes} minutes";

                    var pieChart = new LiveCharts.WinForms.PieChart
                    {
                        Size = new Size(300, 300),
                        Location = new Point((this.ClientSize.Width - 300) / 2, (this.ClientSize.Height - 300) / 2),
                        Anchor = AnchorStyles.None
                    };

                    pieChart.Series = new SeriesCollection
                    {
                        new PieSeries
                        {
                            Title = "Pending",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(pendingTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"Pending: {pendingTasks}"
                        },
                        new PieSeries
                        {
                            Title = "In Progress",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(inProgressTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"In Progress: {inProgressTasks}"
                        },
                        new PieSeries
                        {
                            Title = "Completed",
                            Values = new ChartValues<ObservableValue> { new ObservableValue(completedTasks) },
                            DataLabels = true,
                            LabelPoint = chartPoint => $"Completed: {completedTasks}"
                        }
                    };

                    pieChart.DataTooltip = new DefaultTooltip();
                    pieChart.DisableAnimations = false;

                    this.Controls.Add(pieChart);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var context = new DBContext())
            {
                var user = context.Users.Find(Id);
                if (user.Email == "admin")
                {
                    AllTasksForm allTasks = new AllTasksForm(Id);
                    allTasks.Show();
                    this.Close();
                }
                else
                {
                    TasksForm tasks = new TasksForm(user.Id);
                    tasks.Show();
                    this.Close();
                }
            }
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            LoadReportData();
        }
    }
}
