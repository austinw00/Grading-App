namespace GradingApplication.Courses
{
    partial class AssignmentForm
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
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.deleteAssignmentButton = new System.Windows.Forms.Button();
            this.assignmentNameTxt = new System.Windows.Forms.TextBox();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(211, 22);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(115, 23);
            this.saveChangesButton.TabIndex = 1;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // deleteAssignmentButton
            // 
            this.deleteAssignmentButton.Location = new System.Drawing.Point(211, 51);
            this.deleteAssignmentButton.Name = "deleteAssignmentButton";
            this.deleteAssignmentButton.Size = new System.Drawing.Size(115, 23);
            this.deleteAssignmentButton.TabIndex = 2;
            this.deleteAssignmentButton.Text = "Delete Assignment";
            this.deleteAssignmentButton.UseVisualStyleBackColor = true;
            this.deleteAssignmentButton.Click += new System.EventHandler(this.deleteAssignmentButton_Click);
            // 
            // assignmentNameTxt
            // 
            this.assignmentNameTxt.Location = new System.Drawing.Point(105, 10);
            this.assignmentNameTxt.Name = "assignmentNameTxt";
            this.assignmentNameTxt.Size = new System.Drawing.Size(100, 20);
            this.assignmentNameTxt.TabIndex = 3;
            // 
            // gradeTxt
            // 
            this.gradeTxt.Location = new System.Drawing.Point(105, 36);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.Size = new System.Drawing.Size(100, 20);
            this.gradeTxt.TabIndex = 4;
            this.gradeTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(105, 62);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(100, 20);
            this.typeTxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assignment Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grade %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type";
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 92);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.assignmentNameTxt);
            this.Controls.Add(this.deleteAssignmentButton);
            this.Controls.Add(this.saveChangesButton);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            this.Load += new System.EventHandler(this.AssignmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button deleteAssignmentButton;
        private System.Windows.Forms.TextBox assignmentNameTxt;
        private System.Windows.Forms.TextBox gradeTxt;
        private System.Windows.Forms.TextBox typeTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}