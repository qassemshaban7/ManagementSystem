using System;
using System.Windows.Forms;

namespace Management_System
{
    public partial class TaskStatusColumn : DataGridViewColumn
    {
        public TaskStatusColumn() : base(new TaskStatusCell())
        {
            this.CellTemplate = new TaskStatusCell();
            this.Name = "Status";
            this.HeaderText = "Task Status";
        }
    }
}
