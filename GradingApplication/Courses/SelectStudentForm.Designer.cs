namespace GradingApplication.Courses
{
    partial class SelectStudentForm
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
            this.createNewStudentButton = new System.Windows.Forms.Button();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.submitStudentButton = new System.Windows.Forms.Button();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25121F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74879F));
            this.tableLayoutPanel1.Controls.Add(this.createNewStudentButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentsGridView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.submitStudentButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.26761F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.73239F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 284);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // createNewStudentButton
            // 
            this.createNewStudentButton.Location = new System.Drawing.Point(357, 3);
            this.createNewStudentButton.Name = "createNewStudentButton";
            this.createNewStudentButton.Size = new System.Drawing.Size(143, 23);
            this.createNewStudentButton.TabIndex = 0;
            this.createNewStudentButton.Text = "Create New Student";
            this.createNewStudentButton.UseVisualStyleBackColor = true;
            this.createNewStudentButton.Click += new System.EventHandler(this.createNewStudentButton_Click);
            // 
            // studentsGridView
            // 
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Location = new System.Drawing.Point(3, 3);
            this.studentsGridView.Name = "studentsGridView";
            this.tableLayoutPanel1.SetRowSpan(this.studentsGridView, 2);
            this.studentsGridView.Size = new System.Drawing.Size(348, 278);
            this.studentsGridView.TabIndex = 1;
            // 
            // submitStudentButton
            // 
            this.submitStudentButton.Location = new System.Drawing.Point(357, 35);
            this.submitStudentButton.Name = "submitStudentButton";
            this.submitStudentButton.Size = new System.Drawing.Size(143, 23);
            this.submitStudentButton.TabIndex = 2;
            this.submitStudentButton.Text = "Add Student to Course";
            this.submitStudentButton.UseVisualStyleBackColor = true;
            this.submitStudentButton.Click += new System.EventHandler(this.submitStudentButton_Click);
            // 
            // SelectStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 284);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectStudentForm";
            this.Text = "SelectStudentForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button createNewStudentButton;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.Button submitStudentButton;
    }
}