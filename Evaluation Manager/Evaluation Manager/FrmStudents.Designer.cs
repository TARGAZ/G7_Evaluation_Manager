﻿namespace Evaluation_Manager
{
    partial class FrmStudents
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
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.btnEvaluateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentDGV
            // 
            this.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDGV.Location = new System.Drawing.Point(12, 12);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.RowHeadersWidth = 51;
            this.StudentDGV.RowTemplate.Height = 24;
            this.StudentDGV.Size = new System.Drawing.Size(711, 408);
            this.StudentDGV.TabIndex = 0;
            // 
            // btnEvaluateStudent
            // 
            this.btnEvaluateStudent.Location = new System.Drawing.Point(554, 447);
            this.btnEvaluateStudent.Name = "btnEvaluateStudent";
            this.btnEvaluateStudent.Size = new System.Drawing.Size(146, 36);
            this.btnEvaluateStudent.TabIndex = 1;
            this.btnEvaluateStudent.Text = "Evaluate student";
            this.btnEvaluateStudent.UseVisualStyleBackColor = true;
            this.btnEvaluateStudent.Click += new System.EventHandler(this.btnEvaluateStudent_Click);
            // 
            // FrmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 510);
            this.Controls.Add(this.btnEvaluateStudent);
            this.Controls.Add(this.StudentDGV);
            this.Name = "FrmStudents";
            this.Text = "FrmStudents";
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.Button btnEvaluateStudent;
    }
}