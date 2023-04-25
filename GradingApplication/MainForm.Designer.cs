namespace GradingApplication
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manageStudents = new System.Windows.Forms.Button();
            this.manageCoursesButton = new System.Windows.Forms.Button();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.manageCoursesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.manageStudents, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseListBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // manageStudents
            // 
            this.manageStudents.Location = new System.Drawing.Point(403, 228);
            this.manageStudents.Name = "manageStudents";
            this.manageStudents.Size = new System.Drawing.Size(133, 33);
            this.manageStudents.TabIndex = 0;
            this.manageStudents.Text = "Students";
            this.manageStudents.UseVisualStyleBackColor = true;
            this.manageStudents.Click += new System.EventHandler(this.manageStudents_Click);
            // 
            // manageCoursesButton
            // 
            this.manageCoursesButton.Location = new System.Drawing.Point(403, 3);
            this.manageCoursesButton.Name = "manageCoursesButton";
            this.manageCoursesButton.Size = new System.Drawing.Size(133, 33);
            this.manageCoursesButton.TabIndex = 1;
            this.manageCoursesButton.Text = "Courses";
            this.manageCoursesButton.UseVisualStyleBackColor = true;
            this.manageCoursesButton.Click += new System.EventHandler(this.manageCoursesButton_Click);
            // 
            // courseListBox
            // 
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.Location = new System.Drawing.Point(3, 3);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(120, 95);
            this.courseListBox.TabIndex = 2;
            this.courseListBox.DoubleClick += new System.EventHandler(this.courseListBox_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button manageStudents;
        private System.Windows.Forms.Button manageCoursesButton;
        private System.Windows.Forms.ListBox courseListBox;
    }
}

