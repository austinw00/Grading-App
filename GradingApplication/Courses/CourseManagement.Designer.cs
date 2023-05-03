namespace GradingApplication.Courses
{
    partial class CourseManagement
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
            this.addCourseButton = new System.Windows.Forms.Button();
            this.removeCourseButton = new System.Windows.Forms.Button();
            this.courseGridView = new System.Windows.Forms.DataGridView();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.06294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.72028F));
            this.tableLayoutPanel1.Controls.Add(this.addCourseButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeCourseButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.courseGridView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(3, 3);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(75, 23);
            this.addCourseButton.TabIndex = 0;
            this.addCourseButton.Text = "Add Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // removeCourseButton
            // 
            this.removeCourseButton.Location = new System.Drawing.Point(3, 35);
            this.removeCourseButton.Name = "removeCourseButton";
            this.removeCourseButton.Size = new System.Drawing.Size(105, 23);
            this.removeCourseButton.TabIndex = 1;
            this.removeCourseButton.Text = "Remove Course";
            this.removeCourseButton.UseVisualStyleBackColor = true;
            this.removeCourseButton.Click += new System.EventHandler(this.removeCourseButton_Click);
            // 
            // courseGridView
            // 
            this.courseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseGridView.Location = new System.Drawing.Point(165, 3);
            this.courseGridView.Name = "courseGridView";
            this.tableLayoutPanel1.SetRowSpan(this.courseGridView, 2);
            this.courseGridView.Size = new System.Drawing.Size(296, 279);
            this.courseGridView.TabIndex = 2;
            this.courseGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.courseGridView_CellContentClick);
            // 
            // CourseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CourseManagement";
            this.Text = "CourseManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.Button removeCourseButton;
        private System.Windows.Forms.DataGridView courseGridView;
        private System.Windows.Forms.BindingSource courseBindingSource;
    }
}