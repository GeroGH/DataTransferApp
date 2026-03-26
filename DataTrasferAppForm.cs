using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ExcelDataReader;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Color = System.Drawing.Color;

namespace DataTransferApp
{
    public partial class DataTransferApp : Form
    {
        private readonly string filePath = Properties.Settings.Default.DataFilePath;

        public DataTransferApp()
        {
            this.InitializeComponent();
        }

        private void DataTransferApp_Load(object sender, EventArgs e)
        {
            this.MoveForm();

            if (!File.Exists(this.filePath))
                return;

            this.LoadExcelFromFile(this.filePath);
        }

        private void MoveForm()
        {
            var currentScreen = Screen.FromPoint(Cursor.Position);
            var workingArea = currentScreen.WorkingArea;
            this.Location = new Point(workingArea.Right - this.Width - 50, workingArea.Top + 150);
        }

        private void LoadExcelFromFile(string path)
        {
            if (!File.Exists(path))
                return;

            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var config = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = delegate
                    {
                        return new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        };
                    }
                };

                var dataSet = reader.AsDataSet(config);
                var table = dataSet.Tables[0];

                this.DataGridView.DataSource = table;

                var emptyRow = table.NewRow();
                table.Rows.Add(emptyRow);

                this.ConfigureGrid();
                this.ConfigureColumns();

                this.FileLocationLabel.Text = path;
            }
        }

        private void ConfigureGrid()
        {
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.ReadOnly = true;
            this.DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.MultiSelect = false;
            this.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridView.AllowUserToAddRows = false;

            this.DataGridView.EnableHeadersVisualStyles = false;

            this.DataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);

            this.DataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
            this.DataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkCyan;
            this.DataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkCyan;
        }

        private void ConfigureColumns()
        {
            if (this.DataGridView.Columns.Contains("IfcGUID"))
                this.DataGridView.Columns.Remove("IfcGUID");

            var dataTable = this.DataGridView.DataSource as DataTable;

            if (dataTable == null)
                return;

            dataTable.DefaultView.Sort = "HS2_Filename, HS2_AssetClassDescr, HS2_AssetReference, HS2_Level";

            this.DataGridView.Columns["HS2_Filename"].DisplayIndex = 0;
            this.DataGridView.Columns["HS2_AssetClassDescr"].DisplayIndex = 1;
            this.DataGridView.Columns["HS2_AssetReference"].DisplayIndex = 2;
            this.DataGridView.Columns["HS2_Level"].DisplayIndex = 3;
        }
        private void UpdateFields_Click(object sender, EventArgs e)
        {
            this.LockControls(true);
            this.Cursor = Cursors.WaitCursor;

            try
            {
                this.SetStatus("Updating Fields ...", Color.Red);

                var selector = new Tekla.Structures.Model.UI.ModelObjectSelector();
                var objects = selector.GetSelectedObjects();

                while (objects.MoveNext())
                {
                    var part = objects.Current as Part;
                    if (part == null) continue;

                    this.UpdatePartProperties(part);
                }

                this.ChangeRepresentation();

                this.SetStatus("Application Ready !!!", Color.Black);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                this.LockControls(false);
            }
        }

        private void LockControls(bool locked)
        {
            this.DataGridView.Enabled = !locked;
            this.ImportExcelData.Enabled = !locked;
            this.ColorByEquipName.Enabled = !locked;
            this.ColorByEquipAssetRef.Enabled = !locked;
            this.FileLocationLabel.Enabled = !locked;
        }

        private void UpdatePartProperties(Part part)
        {
            if (this.DataGridView.CurrentRow == null)
                return;

            var cells = this.DataGridView.CurrentRow.Cells;

            foreach (DataGridViewCell cell in cells)
            {
                var columnName = this.DataGridView.Columns[cell.ColumnIndex].Name;

                var value = cell.Value != null ? cell.Value.ToString() : "";

                part.SetUserProperty(columnName, value);
            }
        }

        private void ChangeRepresentation()
        {
            var views = ViewHandler.GetVisibleViews();

            while (views.MoveNext())
            {
                var view = views.Current;
                view.Modify();
            }
        }

        private void ChangeRepresentation(string representation)
        {
            var views = ViewHandler.GetVisibleViews();

            while (views.MoveNext())
            {
                var view = views.Current;
                view.CurrentRepresentation = representation;
                view.Modify();
            }
        }

        private void SetStatus(string text, Color color)
        {
            this.StatusLabel.Text = text;
            this.StatusLabel.ForeColor = color;
        }

        private void FileLocationLabel_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.filePath))
                Process.Start(this.filePath);
        }

        private void ApplyRepresentation(string representation)
        {
            this.SetStatus("Updating Representation ...", Color.Red);

            this.ChangeRepresentation(representation);

            this.SetStatus("Application Ready !!!", Color.Black);
        }

        private void ColorByEquipName_Click(object sender, EventArgs e)
        {
            this.ApplyRepresentation("Color by EquipName");
        }

        private void ColorByEquipAssetRef_Click(object sender, EventArgs e)
        {
            this.ApplyRepresentation("Color by EquipAssetRef");
        }

        private void FileLocationLabel_DragEnter(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            var newFile = files.FirstOrDefault();

            if (string.IsNullOrEmpty(newFile) || !File.Exists(newFile))
                return;

            this.FileLocationLabel.Text = newFile;

            Properties.Settings.Default.DataFilePath = newFile;
            Properties.Settings.Default.Save();

            this.LoadExcelFromFile(newFile);

            this.SetStatus("New file loaded successfully!", Color.Black);
        }
    }
}