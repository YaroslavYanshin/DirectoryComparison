﻿namespace DirectoryComparison
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDir1 = new System.Windows.Forms.TextBox();
            this.tbDir2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.Directory1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Directory2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDir1 = new System.Windows.Forms.Button();
            this.btnDir2 = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSame = new System.Windows.Forms.TextBox();
            this.cbDir = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Directory 2 :";
            // 
            // tbDir1
            // 
            this.tbDir1.Location = new System.Drawing.Point(103, 31);
            this.tbDir1.Multiline = true;
            this.tbDir1.Name = "tbDir1";
            this.tbDir1.Size = new System.Drawing.Size(540, 25);
            this.tbDir1.TabIndex = 2;
            // 
            // tbDir2
            // 
            this.tbDir2.Location = new System.Drawing.Point(103, 83);
            this.tbDir2.Multiline = true;
            this.tbDir2.Name = "tbDir2";
            this.tbDir2.Size = new System.Drawing.Size(540, 25);
            this.tbDir2.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(305, 123);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(128, 58);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // dgvFiles
            // 
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Directory1,
            this.Directory2});
            this.dgvFiles.Location = new System.Drawing.Point(75, 223);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.Size = new System.Drawing.Size(540, 205);
            this.dgvFiles.TabIndex = 5;
            // 
            // Directory1
            // 
            this.Directory1.HeaderText = "Directory 1";
            this.Directory1.Name = "Directory1";
            // 
            // Directory2
            // 
            this.Directory2.HeaderText = "Directory 2";
            this.Directory2.Name = "Directory2";
            // 
            // btnDir1
            // 
            this.btnDir1.Location = new System.Drawing.Point(649, 31);
            this.btnDir1.Name = "btnDir1";
            this.btnDir1.Size = new System.Drawing.Size(140, 25);
            this.btnDir1.TabIndex = 6;
            this.btnDir1.Text = "Open Directory 1";
            this.btnDir1.UseVisualStyleBackColor = true;
            this.btnDir1.Click += new System.EventHandler(this.btnDir1_Click);
            // 
            // btnDir2
            // 
            this.btnDir2.Location = new System.Drawing.Point(649, 83);
            this.btnDir2.Name = "btnDir2";
            this.btnDir2.Size = new System.Drawing.Size(140, 25);
            this.btnDir2.TabIndex = 7;
            this.btnDir2.Text = "Open Directory 2";
            this.btnDir2.UseVisualStyleBackColor = true;
            this.btnDir2.Click += new System.EventHandler(this.btnDir2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time :";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(688, 220);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 22);
            this.tbTime.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Same :";
            // 
            // tbSame
            // 
            this.tbSame.Location = new System.Drawing.Point(688, 252);
            this.tbSame.Name = "tbSame";
            this.tbSame.Size = new System.Drawing.Size(100, 22);
            this.tbSame.TabIndex = 11;
            // 
            // cbDir
            // 
            this.cbDir.AutoSize = true;
            this.cbDir.Location = new System.Drawing.Point(305, 187);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(110, 21);
            this.cbDir.TabIndex = 12;
            this.cbDir.Text = "Subdirectory";
            this.cbDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbDir);
            this.Controls.Add(this.tbSame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDir2);
            this.Controls.Add(this.btnDir1);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.tbDir2);
            this.Controls.Add(this.tbDir1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Comparison";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDir1;
        private System.Windows.Forms.TextBox tbDir2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.DataGridView dgvFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Directory2;
        private System.Windows.Forms.Button btnDir1;
        private System.Windows.Forms.Button btnDir2;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSame;
        private System.Windows.Forms.CheckBox cbDir;
    }
}

