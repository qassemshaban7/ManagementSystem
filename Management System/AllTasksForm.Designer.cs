namespace Management_System
{
    partial class AllTasksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTasksForm));
            label6 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnNext2 = new Button();
            btnPrevious2 = new Button();
            label7 = new Label();
            label8 = new Label();
            button4 = new Button();
            btnReports = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(710, 6);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 54;
            label6.Text = "Filter by Priority";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(600, 6);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 53;
            label5.Text = "Filter by Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "All", "Low", "Medium", "High" });
            comboBox2.Location = new Point(710, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(102, 23);
            comboBox2.TabIndex = 52;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(224, 224, 224);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(241, 10);
            button3.Name = "button3";
            button3.Size = new Size(110, 40);
            button3.TabIndex = 51;
            button3.Text = "Group by Priority";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(396, 6);
            label4.Name = "label4";
            label4.Size = new Size(195, 15);
            label4.TabIndex = 50;
            label4.Text = "Search by Title & Desc & UserName";
            label4.UseMnemonic = false;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.CausesValidation = false;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(359, 6);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(40, 44);
            label3.TabIndex = 49;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(357, 18);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 48;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 47;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Pending", "InProgress", "Completed" });
            comboBox1.Location = new Point(600, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 23);
            comboBox1.TabIndex = 46;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(13, 10);
            button1.Name = "button1";
            button1.Size = new Size(117, 40);
            button1.TabIndex = 45;
            button1.Text = "Add New Task";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI", 15F);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(333, 70);
            label1.Name = "label1";
            label1.Size = new Size(187, 31);
            label1.TabIndex = 44;
            label1.Text = "Tasks Item";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(846, 278);
            dataGridView1.TabIndex = 43;
            // 
            // btnNext2
            // 
            btnNext2.Location = new Point(486, 412);
            btnNext2.Name = "btnNext2";
            btnNext2.Size = new Size(75, 23);
            btnNext2.TabIndex = 55;
            btnNext2.Text = "Next";
            btnNext2.UseVisualStyleBackColor = true;
            btnNext2.Click += btnNext2_Click;
            // 
            // btnPrevious2
            // 
            btnPrevious2.Location = new Point(291, 412);
            btnPrevious2.Name = "btnPrevious2";
            btnPrevious2.Size = new Size(75, 23);
            btnPrevious2.TabIndex = 56;
            btnPrevious2.Text = "Previous";
            btnPrevious2.UseVisualStyleBackColor = true;
            btnPrevious2.Click += btnPrevious2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 416);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 57;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(124, 416);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 58;
            label8.Text = "label8";
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(725, 408);
            button4.Name = "button4";
            button4.Size = new Size(74, 30);
            button4.TabIndex = 59;
            button4.Text = "Back";
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
            btnReports.Location = new Point(136, 10);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(98, 38);
            btnReports.TabIndex = 60;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleRight;
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // AllTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 451);
            Controls.Add(btnReports);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnPrevious2);
            Controls.Add(btnNext2);
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
            Name = "AllTasksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AllTasksForm";
            Load += AllTasksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private ComboBox comboBox2;
        private Button button3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnNext2;
        private Button btnPrevious2;
        private Label label7;
        private Label label8;
        private Button button4;
        private Button btnReports;
    }
}