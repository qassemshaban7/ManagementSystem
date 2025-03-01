namespace Management_System
{
    partial class TasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksForm));
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            btnNext = new Button();
            btnPrevious = new Button();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            btnReports = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 27;
            button1.Text = "Add New Task";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI", 15F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(282, 69);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 26;
            label1.Text = "Tasks Item";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 284);
            dataGridView1.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Pending", "InProgress", "Completed" });
            comboBox1.Location = new Point(535, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(84, 23);
            comboBox1.TabIndex = 28;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(354, 21);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 31;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.CausesValidation = false;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(355, 9);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(40, 44);
            label3.TabIndex = 34;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 9);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 35;
            label4.Text = "Search by Title or Desc";
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(240, 9);
            button3.Name = "button3";
            button3.Size = new Size(108, 40);
            button3.TabIndex = 36;
            button3.Text = "Group by Priority";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All", "Low", "Medium", "High" });
            comboBox2.Location = new Point(637, 30);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(90, 23);
            comboBox2.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(535, 9);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 38;
            label5.Text = "Filter by Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(637, 12);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 39;
            label6.Text = "Filter by Priority";
            // 
            // btnNext
            // 
            btnNext.Location = new Point(441, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 40;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(235, 400);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 41;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(346, 408);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 42;
            label7.Text = "labelPage";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(91, 404);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 43;
            label8.Text = "label8";
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(612, 393);
            button4.Name = "button4";
            button4.Size = new Size(89, 36);
            button4.TabIndex = 44;
            button4.Text = "Log Out";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnReports
            // 
            btnReports.BackColor = Color.Silver;
            btnReports.BackgroundImage = (Image)resources.GetObject("btnReports.BackgroundImage");
            btnReports.BackgroundImageLayout = ImageLayout.None;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(135, 9);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(98, 40);
            btnReports.TabIndex = 45;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleRight;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // TasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 442);
            Controls.Add(btnReports);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Name = "TasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks";
            Load += TasksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private Button btnNext;
        private Button btnPrevious;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button btnReports;
    }
}