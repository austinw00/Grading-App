﻿namespace GradingApplication.Courses
{
    partial class StudentGradesForm
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
            this.assignmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.assignmentNameTxt = new System.Windows.Forms.TextBox();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAssignmentButton = new System.Windows.Forms.Button();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.overallGradeLabel = new System.Windows.Forms.Label();
            this.letterGradeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.625F));
            this.tableLayoutPanel1.Controls.Add(this.assignmentsDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.assignmentNameTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.gradeTxt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddAssignmentButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.typeTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.overallGradeLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.letterGradeLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.studentNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.courseNameLabel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // assignmentsDataGridView
            // 
            this.assignmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentsDataGridView.Location = new System.Drawing.Point(3, 93);
            this.assignmentsDataGridView.Name = "assignmentsDataGridView";
            this.tableLayoutPanel1.SetRowSpan(this.assignmentsDataGridView, 3);
            this.assignmentsDataGridView.Size = new System.Drawing.Size(324, 264);
            this.assignmentsDataGridView.TabIndex = 2;
            this.assignmentsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.assignmentsDataGridView_DoubleClick);
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.courseNameLabel, 2);
            this.courseNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.courseNameLabel.Location = new System.Drawing.Point(333, 0);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(60, 24);
            this.courseNameLabel.TabIndex = 1;
            this.courseNameLabel.Text = "label1";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.studentNameLabel.Location = new System.Drawing.Point(3, 0);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(60, 24);
            this.studentNameLabel.TabIndex = 0;
            this.studentNameLabel.Text = "label1";
            // 
            // assignmentNameTxt
            // 
            this.assignmentNameTxt.Location = new System.Drawing.Point(437, 93);
            this.assignmentNameTxt.Name = "assignmentNameTxt";
            this.assignmentNameTxt.Size = new System.Drawing.Size(99, 20);
            this.assignmentNameTxt.TabIndex = 3;
            // 
            // gradeTxt
            // 
            this.gradeTxt.Location = new System.Drawing.Point(437, 183);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(99, 20);
            this.gradeTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assignment Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grade Percentage:";
            // 
            // AddAssignmentButton
            // 
            this.AddAssignmentButton.Location = new System.Drawing.Point(437, 363);
            this.AddAssignmentButton.Name = "AddAssignmentButton";
            this.AddAssignmentButton.Size = new System.Drawing.Size(99, 23);
            this.AddAssignmentButton.TabIndex = 5;
            this.AddAssignmentButton.Text = "Add Assignment";
            this.AddAssignmentButton.UseVisualStyleBackColor = true;
            this.AddAssignmentButton.Click += new System.EventHandler(this.AddAssignmentButton_Click1);
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(437, 273);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(99, 20);
            this.typeTxt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Type:";
            // 
            // overallGradeLabel
            // 
            this.overallGradeLabel.AutoSize = true;
            this.overallGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.overallGradeLabel.Location = new System.Drawing.Point(542, 0);
            this.overallGradeLabel.Name = "overallGradeLabel";
            this.overallGradeLabel.Size = new System.Drawing.Size(133, 25);
            this.overallGradeLabel.TabIndex = 10;
            this.overallGradeLabel.Text = "Overall Grade";
            // 
            // letterGradeLabel
            // 
            this.letterGradeLabel.AutoSize = true;
            this.letterGradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.letterGradeLabel.Location = new System.Drawing.Point(542, 90);
            this.letterGradeLabel.Name = "letterGradeLabel";
            this.letterGradeLabel.Size = new System.Drawing.Size(133, 25);
            this.letterGradeLabel.TabIndex = 11;
            this.letterGradeLabel.Text = "Overall Grade";
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentGradesForm";
            this.Text = "StudentGradesForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.DataGridView assignmentsDataGridView;
        private System.Windows.Forms.TextBox assignmentNameTxt;
        private System.Windows.Forms.TextBox gradeTxt;
        private System.Windows.Forms.Button AddAssignmentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label overallGradeLabel;
        private System.Windows.Forms.Label letterGradeLabel;
    }
}