namespace Management_System
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            pictureBox1 = new PictureBox();
            lblCompletedCount = new Label();
            lblPendingCount = new Label();
            lblAvgCompletionTime = new Label();
            lblInProgressCount = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 62);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblCompletedCount
            // 
            lblCompletedCount.AutoSize = true;
            lblCompletedCount.Location = new Point(243, 12);
            lblCompletedCount.Name = "lblCompletedCount";
            lblCompletedCount.Size = new Size(38, 15);
            lblCompletedCount.TabIndex = 3;
            lblCompletedCount.Text = "label1";
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.Location = new Point(104, 12);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(38, 15);
            lblPendingCount.TabIndex = 4;
            lblPendingCount.Text = "label1";
            // 
            // lblAvgCompletionTime
            // 
            lblAvgCompletionTime.AutoSize = true;
            lblAvgCompletionTime.Location = new Point(243, 41);
            lblAvgCompletionTime.Name = "lblAvgCompletionTime";
            lblAvgCompletionTime.Size = new Size(38, 15);
            lblAvgCompletionTime.TabIndex = 5;
            lblAvgCompletionTime.Text = "label1";
            // 
            // lblInProgressCount
            // 
            lblInProgressCount.AutoSize = true;
            lblInProgressCount.Location = new Point(104, 41);
            lblInProgressCount.Name = "lblInProgressCount";
            lblInProgressCount.Size = new Size(38, 15);
            lblInProgressCount.TabIndex = 8;
            lblInProgressCount.Text = "label1";
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(521, 383);
            button4.Name = "button4";
            button4.Size = new Size(74, 30);
            button4.TabIndex = 60;
            button4.Text = "Back";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 425);
            Controls.Add(button4);
            Controls.Add(lblInProgressCount);
            Controls.Add(lblAvgCompletionTime);
            Controls.Add(lblPendingCount);
            Controls.Add(lblCompletedCount);
            Controls.Add(pictureBox1);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label lblCompletedCount;
        private Label lblPendingCount;
        private Label lblAvgCompletionTime;
        private Label lblInProgressCount;
        private Button button4;
    }
}