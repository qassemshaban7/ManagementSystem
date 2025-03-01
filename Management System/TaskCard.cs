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
    public partial class TaskCard : UserControl
    {
        public TaskCard()
        {
            InitializeComponent();
        }

        public string TaskStatus
        {
            get => lblStatus.Text;
            set
            {
                lblStatus.Text = value;
                lblStatus.BackColor = GetStatusColor(value);
                lblStatus.ForeColor = Color.White;
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status.Trim().ToLower())
            {
                case "pending":
                    return Color.Orange;
                case "inprogress":
                    return Color.Blue;
                case "completed":
                    return Color.Green;
                default:
                    return Color.Gray;
            }
        }
    }
}