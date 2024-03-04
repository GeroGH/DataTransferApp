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
            this.OpenExcelFile = new System.Windows.Forms.Button();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteFields
            // 
            this.DeleteFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFields.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFields.Location = new System.Drawing.Point(403, 171);
            this.DeleteFields.Name = "DeleteFields";
            this.DeleteFields.Size = new System.Drawing.Size(387, 58);
            this.DeleteFields.TabIndex = 7;
            this.DeleteFields.Text = "Clean Fields Values";
            this.DeleteFields.UseVisualStyleBackColor = true;
            this.DeleteFields.Click += new System.EventHandler(this.DeleteFields_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(12, 25);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(1169, 140);
            this.DataGridView.TabIndex = 6;
            // 
            // UpdateFields
            // 
            this.UpdateFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFields.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateFields.Location = new System.Drawing.Point(12, 171);
            this.UpdateFields.Name = "UpdateFields";
            this.UpdateFields.Size = new System.Drawing.Size(387, 58);
            this.UpdateFields.TabIndex = 5;
            this.UpdateFields.Text = "Update Fields Values";
            this.UpdateFields.UseVisualStyleBackColor = true;
            this.UpdateFields.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // OpenExcelFile
            // 
            this.OpenExcelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenExcelFile.ForeColor = System.Drawing.Color.ForestGreen;
            this.OpenExcelFile.Location = new System.Drawing.Point(794, 171);
            this.OpenExcelFile.Name = "OpenExcelFile";
            this.OpenExcelFile.Size = new System.Drawing.Size(387, 58);
            this.OpenExcelFile.TabIndex = 9;
            this.OpenExcelFile.Text = "Open Excel File";
            this.OpenExcelFile.UseVisualStyleBackColor = true;
            this.OpenExcelFile.Click += new System.EventHandler(this.OpenExcelFile_Click);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AutoSize = true;
            this.FileLocationLabel.Location = new System.Drawing.Point(12, 9);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(90, 13);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Text = "FileLocationLabel";
            // 
            // DataTransferApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 237);
            this.Controls.Add(this.FileLocationLabel);
            this.Controls.Add(this.OpenExcelFile);
            this.Controls.Add(this.DeleteFields);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.UpdateFields);
            this.Name = "DataTransferApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Application v 2024.03.04 c";
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
        private System.Windows.Forms.Button OpenExcelFile;
        private System.Windows.Forms.Label FileLocationLabel;
    }
}

