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
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteFields
            // 
            this.DeleteFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFields.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFields.Location = new System.Drawing.Point(432, 146);
            this.DeleteFields.Name = "DeleteFields";
            this.DeleteFields.Size = new System.Drawing.Size(410, 60);
            this.DeleteFields.TabIndex = 7;
            this.DeleteFields.Text = "Clean Fields";
            this.DeleteFields.UseVisualStyleBackColor = true;
            this.DeleteFields.Click += new System.EventHandler(this.DeleteFields_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(12, 25);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(830, 115);
            this.DataGridView.TabIndex = 6;
            // 
            // UpdateFields
            // 
            this.UpdateFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFields.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateFields.Location = new System.Drawing.Point(12, 146);
            this.UpdateFields.Name = "UpdateFields";
            this.UpdateFields.Size = new System.Drawing.Size(410, 60);
            this.UpdateFields.TabIndex = 5;
            this.UpdateFields.Text = "Update Fields";
            this.UpdateFields.UseVisualStyleBackColor = true;
            this.UpdateFields.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationLabel.Location = new System.Drawing.Point(12, 9);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(107, 13);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Text = "FileLocationLabel";
            this.FileLocationLabel.Click += new System.EventHandler(this.FileLocationLabel_Click);
            // 
            // DataTransferApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 212);
            this.Controls.Add(this.FileLocationLabel);
            this.Controls.Add(this.DeleteFields);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.UpdateFields);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataTransferApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Data Transfer Application v 2024.06.18 c";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataTransferApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button DeleteFields;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button UpdateFields;
        private System.Windows.Forms.Label FileLocationLabel;
    }
}

