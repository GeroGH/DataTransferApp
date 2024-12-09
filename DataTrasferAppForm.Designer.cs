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
            this.ImportExcelData = new System.Windows.Forms.Button();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CombineFields = new System.Windows.Forms.Button();
            this.ColorByEquipName = new System.Windows.Forms.Button();
            this.ColorByEquipNumber = new System.Windows.Forms.Button();
            this.ColorByEquipAssetRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteFields
            // 
            this.DeleteFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFields.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFields.Location = new System.Drawing.Point(12, 320);
            this.DeleteFields.Name = "DeleteFields";
            this.DeleteFields.Size = new System.Drawing.Size(230, 53);
            this.DeleteFields.TabIndex = 7;
            this.DeleteFields.Text = "Clean Fields";
            this.DeleteFields.UseVisualStyleBackColor = true;
            this.DeleteFields.Click += new System.EventHandler(this.DeleteFields_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(12, 68);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(466, 136);
            this.DataGridView.TabIndex = 6;
            // 
            // ImportExcelData
            // 
            this.ImportExcelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportExcelData.ForeColor = System.Drawing.Color.DarkGreen;
            this.ImportExcelData.Location = new System.Drawing.Point(12, 206);
            this.ImportExcelData.Name = "ImportExcelData";
            this.ImportExcelData.Size = new System.Drawing.Size(230, 53);
            this.ImportExcelData.TabIndex = 5;
            this.ImportExcelData.Text = "Import Excel Data";
            this.ImportExcelData.UseVisualStyleBackColor = true;
            this.ImportExcelData.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.FileLocationLabel.Location = new System.Drawing.Point(7, 16);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(453, 35);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Text = "FileLocationLabel";
            this.FileLocationLabel.Click += new System.EventHandler(this.FileLocationLabel_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(11, 21);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(151, 16);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Application Ready !!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileLocationLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel File Location:";
            // 
            // CombineFields
            // 
            this.CombineFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombineFields.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CombineFields.Location = new System.Drawing.Point(12, 263);
            this.CombineFields.Name = "CombineFields";
            this.CombineFields.Size = new System.Drawing.Size(230, 53);
            this.CombineFields.TabIndex = 14;
            this.CombineFields.Text = "Combine Fields";
            this.CombineFields.UseVisualStyleBackColor = true;
            this.CombineFields.Click += new System.EventHandler(this.CombineFields_Click);
            // 
            // ColorByEquipName
            // 
            this.ColorByEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorByEquipName.ForeColor = System.Drawing.Color.Black;
            this.ColorByEquipName.Location = new System.Drawing.Point(248, 206);
            this.ColorByEquipName.Name = "ColorByEquipName";
            this.ColorByEquipName.Size = new System.Drawing.Size(230, 53);
            this.ColorByEquipName.TabIndex = 15;
            this.ColorByEquipName.Text = "Color By Name";
            this.ColorByEquipName.UseVisualStyleBackColor = true;
            this.ColorByEquipName.Click += new System.EventHandler(this.ColorByEquipName_Click);
            // 
            // ColorByEquipNumber
            // 
            this.ColorByEquipNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorByEquipNumber.ForeColor = System.Drawing.Color.Black;
            this.ColorByEquipNumber.Location = new System.Drawing.Point(248, 263);
            this.ColorByEquipNumber.Name = "ColorByEquipNumber";
            this.ColorByEquipNumber.Size = new System.Drawing.Size(230, 53);
            this.ColorByEquipNumber.TabIndex = 16;
            this.ColorByEquipNumber.Text = "Color By Number";
            this.ColorByEquipNumber.UseVisualStyleBackColor = true;
            this.ColorByEquipNumber.Click += new System.EventHandler(this.ColorByEquipNumber_Click);
            // 
            // ColorByEquipAssetRef
            // 
            this.ColorByEquipAssetRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorByEquipAssetRef.ForeColor = System.Drawing.Color.Black;
            this.ColorByEquipAssetRef.Location = new System.Drawing.Point(248, 320);
            this.ColorByEquipAssetRef.Name = "ColorByEquipAssetRef";
            this.ColorByEquipAssetRef.Size = new System.Drawing.Size(230, 53);
            this.ColorByEquipAssetRef.TabIndex = 17;
            this.ColorByEquipAssetRef.Text = "Color By Asset Ref";
            this.ColorByEquipAssetRef.UseVisualStyleBackColor = true;
            this.ColorByEquipAssetRef.Click += new System.EventHandler(this.ColorByEquipAssetRef_Click);
            // 
            // DataTransferApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 439);
            this.Controls.Add(this.ColorByEquipAssetRef);
            this.Controls.Add(this.ColorByEquipNumber);
            this.Controls.Add(this.ColorByEquipName);
            this.Controls.Add(this.CombineFields);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteFields);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ImportExcelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataTransferApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Application v 2024.12.09 a";
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
        private System.Windows.Forms.Button ImportExcelData;
        private System.Windows.Forms.Label FileLocationLabel;
        private Label StatusLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button CombineFields;
        private Button ColorByEquipName;
        private Button ColorByEquipNumber;
        private Button ColorByEquipAssetRef;
    }
}

