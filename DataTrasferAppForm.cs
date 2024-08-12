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
        private readonly string DataAssetFileName = "HS2 Asset Data.xlsx";
        private string DataFileLocation = string.Empty;

        private string ModelFolder = string.Empty;

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
                    this.DataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                    this.DataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                    this.DataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
                    this.DataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan;
                }
            }
        }

        private void UpdateFields_Click(object sender, System.EventArgs e)
        {

            this.StatusLabel.Text = "Updating Fields ...";
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;

            if (this.DataGridView.SelectedRows.Count == 0)
            {
                this.StatusLabel.Text = "Updating Representation ...";
                this.ChangeRepresentation("Color by EquipName");
                this.StatusLabel.Text = "Application Ready !!!";
                this.StatusLabel.ForeColor = System.Drawing.Color.Black;
                return;
            }

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

            this.StatusLabel.Text = "Updating Representation ...";
            this.ChangeRepresentation("Color by EquipName");
            this.StatusLabel.Text = "Application Ready !!!";
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
        }

        private void DeleteFields_Click(object sender, System.EventArgs e)
        {
            this.StatusLabel.Text = "Updating Fields ...";
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;

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

            this.StatusLabel.Text = "Updating Representation ...";
            this.ChangeRepresentation("Color by EquipName");
            this.StatusLabel.Text = "Application Ready !!!";
            this.StatusLabel.ForeColor = System.Drawing.Color.Black;
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