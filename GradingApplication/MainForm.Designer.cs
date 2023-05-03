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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.manageCoursesButton = new System.Windows.Forms.Button();
            this.manageStudents = new System.Windows.Forms.Button();
            this.courseDataGridView = new System.Windows.Forms.DataGridView();
            this.enterCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.36782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tableLayoutPanel1.Controls.Add(this.manageCoursesButton, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.manageStudents, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.courseDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.enterCourseButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // manageCoursesButton
            // 
            this.manageCoursesButton.Location = new System.Drawing.Point(445, 141);
            this.manageCoursesButton.Name = "manageCoursesButton";
            this.manageCoursesButton.Size = new System.Drawing.Size(216, 33);
            this.manageCoursesButton.TabIndex = 1;
            this.manageCoursesButton.Text = "Course Manager";
            this.manageCoursesButton.UseVisualStyleBackColor = true;
            this.manageCoursesButton.Click += new System.EventHandler(this.manageCoursesButton_Click);
            // 
            // manageStudents
            // 
            this.manageStudents.Location = new System.Drawing.Point(445, 210);
            this.manageStudents.Name = "manageStudents";
            this.manageStudents.Size = new System.Drawing.Size(216, 33);
            this.manageStudents.TabIndex = 0;
            this.manageStudents.Text = "Student Manager";
            this.manageStudents.UseVisualStyleBackColor = true;
            this.manageStudents.Click += new System.EventHandler(this.manageStudents_Click);
            // 
            // courseDataGridView
            // 
            this.courseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.courseDataGridView, 2);
            this.courseDataGridView.Location = new System.Drawing.Point(3, 72);
            this.courseDataGridView.Name = "courseDataGridView";
            this.courseDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.tableLayoutPanel1.SetRowSpan(this.courseDataGridView, 4);
            this.courseDataGridView.Size = new System.Drawing.Size(436, 271);
            this.courseDataGridView.TabIndex = 3;
            // 
            // enterCourseButton
            // 
            this.enterCourseButton.Location = new System.Drawing.Point(445, 279);
            this.enterCourseButton.Name = "enterCourseButton";
            this.enterCourseButton.Size = new System.Drawing.Size(216, 33);
            this.enterCourseButton.TabIndex = 4;
            this.enterCourseButton.Text = "Open Course";
            this.enterCourseButton.UseVisualStyleBackColor = true;
            this.enterCourseButton.Click += new System.EventHandler(this.enterCourseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(224, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grading Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 416);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button manageStudents;
        private System.Windows.Forms.Button manageCoursesButton;
        private System.Windows.Forms.DataGridView courseDataGridView;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.Button enterCourseButton;
        private System.Windows.Forms.Label label1;
    }
}

