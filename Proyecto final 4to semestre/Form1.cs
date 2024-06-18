using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_4to_semestre
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Server=DESKTOP-O58ILA\SQLEXPRESS;Database=Restaurante;Integrated Security=True;";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadFromDatabase_Click(object sender, EventArgs e)
        {
            LoadDataDatabase();

        }
        private void LoadDataDatabase()
        {
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Comida", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml|JSON files (*.json)|*.json"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                switch (extension)
                {

                    case ".xml":
                        XML(filePath);
                        break;
                    case ".csv":
                        CSV(filePath);
                        break;
                    case ".json":
                        JSON(filePath);
                        break;
                    default:
                        MessageBox.Show("Unsupported file format");
                        break;
                }
            }
        }
        private void CSV(string filePath)
        {
            try
            {
                DataTable dataTable = new DataTable();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CSV: " + ex.Message);
            }
        }

        private void XML(string filePath)
        {
            try
            {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(filePath);
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading XML: " + ex.Message);
            }
        }

        private void JSON(string filePath)
        {
            try
            {
                string jsonData = File.ReadAllText(filePath);
                DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(jsonData);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading JSON: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataGridView1.DataSource;

            // Create a new row with empty values
            DataRow newRow = dataTable.NewRow();
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                newRow[i] = DBNull.Value; // Set default values as appropriate
            }

            // Add the new row to the DataTable
            dataTable.Rows.Add(newRow);

            // Update the DataGridView to reflect the changes
            dataGridView1.Refresh();
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            SAVETODATABASE();

        }
        private void SAVETODATABASE()
        {
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Comida", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnSaveToJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files (*.json)|*.json";
            saveFileDialog.Title = "Save data to XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                JSON(filePath);
            }
        }

        private void btnSaveToXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml";
            saveFileDialog.Title = "Save data to XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                XML(filePath);
            }
        }

        private void btnSaveToCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Save data to CSV";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                CSV(filePath);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
