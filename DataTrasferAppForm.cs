using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using ModelObjectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace DataTransferApp
{
    public partial class DataTransferApp : Form
    {
        private string DataAssetFileName = string.Empty;
        private string ModelFolder = string.Empty;
        private string DataFileLocation = string.Empty;
        public DataTransferApp()
        {
            this.InitializeComponent();
        }

        private void DataTransferApp_Load(object sender, System.EventArgs e)
        {
            var currentFormLocation = this.Location;
            this.Location = new Point(currentFormLocation.X - 475, currentFormLocation.Y - 250);

            var model = new Model();
            this.ModelFolder = model.GetInfo().ModelPath;

            this.DataAssetFileName = "HS2 Asset Data.xlsx";

            this.DataFileLocation = Path.Combine(this.ModelFolder, this.DataAssetFileName);

            using (var stream = File.Open(this.DataFileLocation, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var conf = new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = config => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);
                    var dataTableCollection = dataSet.Tables;
                    var AssetClasses = dataTableCollection[0];
                    this.DataGridView.DataSource = AssetClasses;
                    this.DataGridView.RowHeadersVisible = false;
                    this.DataGridView.AllowUserToResizeRows = false;
                    this.DataGridView.ReadOnly = true;
                    this.DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.DataGridView.MultiSelect = false;
                    this.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    this.DataGridView.AllowUserToAddRows = false;
                    this.FileLocationLabel.Text = this.DataFileLocation;
                    this.DataGridView.EnableHeadersVisualStyles = false;
                    this.DataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
                    this.DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(this.DataGridView.ColumnHeadersDefaultCellStyle.Font, FontStyle.Bold); ;
                }
            }
        }

        private void UpdateFields_Click(object sender, System.EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();

            while (moe.MoveNext())
            {
                var part = moe.Current as Part;
                if (part == null)
                {
                    continue;
                }

                var cells = this.DataGridView.CurrentRow.Cells;

                foreach (DataGridViewCell cell in cells)
                {
                    var columnName = this.DataGridView.Columns[cell.ColumnIndex].Name;
                    var value = cell.Value.ToString();

                    part.SetUserProperty(columnName, value);
                }

            }

            this.ChangeRepresentation("Color by EquipName");
        }

        private void DeleteFields_Click(object sender, System.EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();

            while (moe.MoveNext())
            {
                var part = moe.Current as Part;
                if (part == null)
                {
                    continue;
                }

                var columns = this.DataGridView.Columns;

                foreach (DataGridViewColumn column in columns)
                {
                    var columnName = column.Name;
                    part.SetUserProperty(columnName, "");
                }

            }

            this.ChangeRepresentation("Color by EquipName");
        }

        private void ChangeRepresentation(string representation)
        {
            var VisibleViews = ViewHandler.GetVisibleViews();
            while (VisibleViews.MoveNext())
            {
                var CurrentView = VisibleViews.Current;
                CurrentView.CurrentRepresentation = representation;
                CurrentView.Modify();
            }
        }
        private void FileLocationLabel_Click(object sender, System.EventArgs e)
        {
            Process.Start(this.DataFileLocation);
        }
    }
}
