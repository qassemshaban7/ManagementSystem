namespace Management_System
{
    partial class AdminAssignTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAssignTask));
            button3 = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            cbUser = new ComboBox();
            richTextBox1 = new RichTextBox();
            label9 = new Label();
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
            label1 = new Label();
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
            button3.Location = new Point(257, 407);
            button3.Name = "button3";
            button3.Size = new Size(111, 35);
            button3.TabIndex = 10;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbUser);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label9);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Location = new Point(34, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 355);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Item Data";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(44, 315);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 23;
            label10.Text = "User:";
            // 
            // cbUser
            // 
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(166, 312);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(200, 23);
            cbUser.TabIndex = 22;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(166, 68);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(200, 58);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 275);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 21;
            label9.Text = "Category:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(166, 272);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(200, 23);
            cbCategory.TabIndex = 20;
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
            cbPriorit.Location = new Point(166, 194);
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
            label7.Location = new Point(44, 197);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 14;
            label7.Text = "Priority :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 155);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "DueDate  :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(166, 149);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 71);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 8;
            label1.Text = "Description :";
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
            button1.Location = new Point(82, 407);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 8;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // AdminAssignTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 465);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "AdminAssignTask";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Assign Task";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox tbTitle;
        private Button button1;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox cbStatus;
        private ComboBox cbPriorit;
        private Label label8;
        private Label label9;
        private ComboBox cbCategory;
        private RichTextBox richTextBox1;
        private Label label10;
        private ComboBox cbUser;
    }
}