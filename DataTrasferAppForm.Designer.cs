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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ImportExcelData = new System.Windows.Forms.Button();
            this.FileLocationLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorByEquipName = new System.Windows.Forms.Button();
            this.ColorByEquipAssetRef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.Location = new System.Drawing.Point(12, 88);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(682, 420);
            this.DataGridView.TabIndex = 6;
            // 
            // ImportExcelData
            // 
            this.ImportExcelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportExcelData.ForeColor = System.Drawing.Color.Black;
            this.ImportExcelData.Location = new System.Drawing.Point(12, 514);
            this.ImportExcelData.Name = "ImportExcelData";
            this.ImportExcelData.Size = new System.Drawing.Size(682, 53);
            this.ImportExcelData.TabIndex = 5;
            this.ImportExcelData.Text = "Import Data From Excel File";
            this.ImportExcelData.UseVisualStyleBackColor = true;
            this.ImportExcelData.Click += new System.EventHandler(this.UpdateFields_Click);
            // 
            // FileLocationLabel
            // 
            this.FileLocationLabel.AllowDrop = true;
            this.FileLocationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileLocationLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.FileLocationLabel.Location = new System.Drawing.Point(7, 16);
            this.FileLocationLabel.Name = "FileLocationLabel";
            this.FileLocationLabel.Size = new System.Drawing.Size(669, 51);
            this.FileLocationLabel.TabIndex = 10;
            this.FileLocationLabel.Text = "Drop file here";
            this.FileLocationLabel.Click += new System.EventHandler(this.FileLocationLabel_Click);
            this.FileLocationLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileLocationLabel_DragEnter);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
            this.StatusLabel.Location = new System.Drawing.Point(11, 21);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(203, 24);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Application Ready !!!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StatusLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 632);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 55);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Status:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FileLocationLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 74);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excel File Location:";
            // 
            // ColorByEquipName
            // 
            this.ColorByEquipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorByEquipName.ForeColor = System.Drawing.Color.Black;
            this.ColorByEquipName.Location = new System.Drawing.Point(12, 573);
            this.ColorByEquipName.Name = "ColorByEquipName";
            this.ColorByEquipName.Size = new System.Drawing.Size(336, 53);
            this.ColorByEquipName.TabIndex = 15;
            this.ColorByEquipName.Tag = "Color by EquipName";
            this.ColorByEquipName.Text = "Color By Name";
            this.ColorByEquipName.UseVisualStyleBackColor = true;
            this.ColorByEquipName.Click += new System.EventHandler(this.ColorByEquipName_Click);
            // 
            // ColorByEquipAssetRef
            // 
            this.ColorByEquipAssetRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorByEquipAssetRef.ForeColor = System.Drawing.Color.Black;
            this.ColorByEquipAssetRef.Location = new System.Drawing.Point(358, 573);
            this.ColorByEquipAssetRef.Name = "ColorByEquipAssetRef";
            this.ColorByEquipAssetRef.Size = new System.Drawing.Size(336, 53);
            this.ColorByEquipAssetRef.TabIndex = 17;
            this.ColorByEquipAssetRef.Tag = "Color by EquipAssetRef";
            this.ColorByEquipAssetRef.Text = "Color By Asset Ref";
            this.ColorByEquipAssetRef.UseVisualStyleBackColor = true;
            this.ColorByEquipAssetRef.Click += new System.EventHandler(this.ColorByEquipAssetRef_Click);
            // 
            // DataTransferApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 693);
            this.Controls.Add(this.ColorByEquipAssetRef);
            this.Controls.Add(this.ColorByEquipName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.ImportExcelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataTransferApp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Transfer Application v11.03.2026c";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataTransferApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ImportExcelData;
        private System.Windows.Forms.Label FileLocationLabel;
        private Label StatusLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button ColorByEquipName;
        private Button ColorByEquipAssetRef;
    }
}

