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
    public partial class TaskStatusCell : DataGridViewTextBoxCell
    {
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates cellState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText,
                cellStyle, advancedBorderStyle, paintParts);

            if (value != null)
            {
                string status = value.ToString();
                Color statusColor = GetStatusColor(status);

                using (Brush brush = new SolidBrush(statusColor))
                {
                    graphics.FillRectangle(brush, cellBounds);
                }

                using (Brush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    graphics.DrawString(status, cellStyle.Font, textBrush, cellBounds, format);
                }
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