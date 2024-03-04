using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;
using Tekla.Structures.Model;
using ModelObjectSelector = Tekla.Structures.Model.UI.ModelObjectSelector;

namespace DataTransferApp
{

    public partial class DataTransferApp : Form
    {
        readonly string DataFileLocation = @"C:\Users\gergan.gospodinov\OneDrive - Bourne Group\TeklaStructuresModels_2023\3375-1 South Ruislip Head House\HS2 Asset Data.xlsx";
        public DataTransferApp()
        {
            this.InitializeComponent();
        }

        private void DataTransferApp_Load(object sender, System.EventArgs e)
        {
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
                    var AssetClasses = dataTableCollection["Asset Classes"];
                    this.DataGridView.DataSource = AssetClasses;
                    this.DataGridView.RowHeadersVisible = false;
                    this.DataGridView.AllowUserToResizeRows = false;
                    this.DataGridView.ReadOnly = true;
                    this.DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    this.DataGridView.MultiSelect = false;
                    this.DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    this.DataGridView.AllowUserToAddRows = false;
                    this.FileLocationLabel.Text = this.DataFileLocation;
                }
            }
        }

        private void UpdateFields_Click(object sender, System.EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();
            var partsToSelelect = new ArrayList();

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

                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }

        private void DeleteFields_Click(object sender, System.EventArgs e)
        {
            var mos = new ModelObjectSelector();
            var moe = mos.GetSelectedObjects();
            var partsToSelelect = new ArrayList();

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

                mos.Select(new ArrayList() { part }, false);
                partsToSelelect.Add(part);
            }

            mos.Select(partsToSelelect, false);
        }

        private void OpenExcelFile_Click(object sender, System.EventArgs e)
        {
            Process.Start(this.DataFileLocation);
        }
    }
}
