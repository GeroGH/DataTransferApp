using System.Drawing;
using System.Windows.Forms;

namespace DataTransferApp
{
    partial class DataTransferApp
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
            this.DeleteFields = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateFields = new System.Windows.Forms.Button();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteFields
            // 
            this.DeleteFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFields.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFields.Location = new System.Drawing.Point(473, 141);
            this.DeleteFields.Name = "DeleteFields";
            this.DeleteFields.Size = new System.Drawing.Size(230, 65);
            this.DeleteFields.TabIndex = 7;
            this.DeleteFields.Text = "Clean Fields";
            this.DeleteFields.UseVisualStyleBackColor = true;
            this.DeleteFields.Click += new System.EventHandler(this.DeleteFields_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(15, 69);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(452, 137);
            this.DataGridView.TabIndex = 6;
            // 
            // UpdateFields
            // 
            this.UpdateFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFields.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateFields.Location = new System.Drawing.Point(473, 69);
            this.UpdateFields.Name = "UpdateFields";
            this.UpdateFields.Size = new System.Drawing.Size(230, 65);
            this.UpdateFields.TabIndex = 5;
            this.UpdateFields.Text = "Update Fields";
            this.UpdateFields.UseVisualStyleBackColor = true;
            this.UpdateFields.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.FileLocationLabel.Location = new System.Drawing.Point(7, 16);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(666, 30);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Text = "FileLocationLabel";
            this.FileLocationLabel.Click += new System.EventHandler(this.FileLocationLabel_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(7, 25);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(151, 16);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Application Ready !!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileLocationLabel);
            this.groupBox2.Location = new System.Drawing.Point(15, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel File Location:";
            // 
            // DataTransferApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 272);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteFields);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.UpdateFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataTransferApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Application v 2024.08.12 a";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataTransferApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteFields;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button UpdateFields;
        private System.Windows.Forms.Label FileLocationLabel;
        private Label StatusLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}

