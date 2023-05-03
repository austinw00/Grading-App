namespace GradingApplication.Courses
{
    partial class CourseForm
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
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.7619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.142857F));
            this.tableLayoutPanel1.Controls.Add(this.removeStudentButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addStudentButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentsGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentsLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.17105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.82895F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // studentsGridView
            // 
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Location = new System.Drawing.Point(181, 45);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.Size = new System.Drawing.Size(341, 298);
            this.studentsGridView.TabIndex = 0;
            this.studentsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsGridView_DoubleClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(3, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 1;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(3, 45);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(97, 23);
            this.removeStudentButton.TabIndex = 2;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.studentsLabel.Location = new System.Drawing.Point(181, 0);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(0, 29);
            this.studentsLabel.TabIndex = 3;
            this.studentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 346);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Label studentsLabel;
    }
}