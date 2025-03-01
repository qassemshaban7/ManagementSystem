namespace Management_System
{
    partial class EditTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            button3 = new Button();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            label11 = new Label();
            cbCategory = new ComboBox();
            cbStatus = new ComboBox();
            cbPriorit = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbTitle = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(284, 369);
            button3.Name = "button3";
            button3.Size = new Size(111, 35);
            button3.TabIndex = 13;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(cbStatus);
            groupBox1.Controls.Add(cbPriorit);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Location = new Point(54, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 327);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Item Data";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(166, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 58);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 144);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 274);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 19;
            label9.Text = "Category:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 71);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 14;
            label11.Text = "Description :";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(166, 271);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 23);
            cbCategory.TabIndex = 18;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(166, 231);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(200, 23);
            cbStatus.TabIndex = 17;
            // 
            // cbPriorit
            // 
            cbPriorit.FormattingEnabled = true;
            cbPriorit.Location = new Point(166, 186);
            cbPriorit.Name = "cbPriorit";
            cbPriorit.Size = new Size(200, 23);
            cbPriorit.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 234);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 15;
            label8.Text = "Status :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 189);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Priority :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 150);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "DueDate  :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 194);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 149);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 111);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 33);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Title :";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(166, 30);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(200, 23);
            tbTitle.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(95, 369);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 11;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 426);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "EditTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTask";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private GroupBox groupBox1;
        private ComboBox cbStatus;
        private ComboBox cbPriorit;
        private Label label8;
        private Label label7;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbTitle;
        private Button button1;
        private Label label9;
        private ComboBox cbCategory;
        private RichTextBox richTextBox1;
        private Label label10;
        private Label label11;
    }
}