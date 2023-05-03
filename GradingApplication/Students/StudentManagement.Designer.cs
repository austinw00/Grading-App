namespace GradingApplication.Students
{
    partial class StudentManagement
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
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeStudentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.CurrentChanged += new System.EventHandler(this.studentsBindingSource_CurrentChanged);
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(118, 3);
            this.studentGridView.Name = "studentGridView";
            this.tableLayoutPanel1.SetRowSpan(this.studentGridView, 2);
            this.studentGridView.Size = new System.Drawing.Size(309, 223);
            this.studentGridView.TabIndex = 1;
            this.studentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGridView_CellContentClick);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(3, 3);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 21);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.9012F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.16422F));
            this.tableLayoutPanel1.Controls.Add(this.addStudentButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.studentGridView, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.removeStudentButton, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8187F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 229);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.Location = new System.Drawing.Point(3, 30);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(105, 23);
            this.removeStudentButton.TabIndex = 2;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            this.removeStudentButton.Click += new System.EventHandler(this.removeStudentButton_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.Button addStudentButton;
    }
}