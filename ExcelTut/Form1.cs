using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ExcelDataReader;
using Z.Dapper.Plus;
using System.Data.SqlClient;

namespace ExcelTut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load() //To tutaj jest chyba nie potrzebne, troche mi sie pomylilo...
        {
            // TODO: This line of code loads data into the 'excelDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.excelDataSet.Customers);
            Excel excel = new Excel(@"Create",2); // tworzymy obiek wywołując konstruktor bez parametrów
            //excel.CreateNewFile(); //tworzymy nowy plik
            //excel.CreateNewSheet();
            excel.SelectWorksheet(2);
            excel.WriteToCell(1, 1, "Ale czadowo");
            excel.DeleteWorksheet(1);
            excel.Save(); //zapisujemy 
            excel.Close();  //zamykamy
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void OpenFile()
        {
            Excel excel = new Excel(@"C:\Users\lucas\source\repos\DesktopApplications\ExcelTut\Test.xlsx", 1);
            Excel excelD = new Excel(@"document.xlsx", 1); //domyślna lokalizacja to localizacja katalogu Dokumenty !!
            
            MessageBox.Show(excelD.ReadCell(0,0));
            MessageBox.Show(excel.ReadCell(0,0));
            
            excel.Close();
            excelD.Close();
        }
        public void WriteData()
        {
            Excel excel = new Excel(@"C:\Users\lucas\source\repos\DesktopApplications\ExcelTut\Test.xlsx", 1);
            excel.WriteToCell(0, 0, "Write test");
            excel.Save();
            //excel.SaveAs(@"C:\Users\lucas\source\repos\DesktopApplications\ExcelTut\Test2.xlsx");
            excel.Close();
        }

        //  DataTableCollection   Represents the collection of tables for the System.Data.DataSet.
        DataTableCollection tableCollection; //DataTableCollection reprezentuje kolekcję tabel dla DataSet 
        //DataSet reprezentuje pamięć podręczną danych

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialog otwiera standardowe okno wybory plików
            using(OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Excel 97-2003 Workbook|*.xls|Excel Workbook | *.xlsx" })
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextBox_Path.Text = openFileDialog.FileName;
                    using(var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            comboBoxSheet.Items.Clear();
                            foreach(DataTable table in tableCollection)
                            {
                                comboBoxSheet.Items.Add(table.TableName); // dodanie arkuszy to ComboBox
                            }
                        }
                    }
                }
            }
           
        }

        private void comboBoxSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  DataTable   Represents one table of in-memory data.
            DataTable dt = tableCollection[comboBoxSheet.SelectedItem.ToString()]; //zmiennej dt, reprezentującej tableę przypisujey tabelę z kolekcji tablek o indeksie z comboBox jako nazwa
            //dgvList.DataSource = dt; // zapełniamy DataGridView tabelą zawartą w zmiennej dt

            if (dt != null)
            {
                List<Customer> Customers = new List<Customer>();
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    Customer customer = new Customer();
                    customer.CustomerID = dt.Rows[i]["ID"].ToString();
                    customer.FirstName = dt.Rows[i]["Name"].ToString();
                    customer.LastName = dt.Rows[i]["Surname"].ToString();
                    customer.Age = dt.Rows[i]["Age"].ToString();
                    Customers.Add(customer);
                }
                customersBindingSource.DataSource = Customers;
            }
        }

        private void buttonExportSQL_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=DESKTOP-EHCH26F\\SQLEXPRESS;Database=Excel;Trusted_Connection=True";
                
                

                DapperPlusManager.Entity<Customer>().Table("Customers");
                List<Customer>customers = customersBindingSource.DataSource as List<Customer>;
                if (customers != null)
                {
                    using(IDbConnection db = new SqlConnection(connString))
                    {
                        //  BulkInsert - An IDbConnection extension method to INSERT entities in a database table or a view.
                        //db.BulkInsert(customers);
                        db.BulkUpdate(customers);
                    }
                    MessageBox.Show("Finish !!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            FormAdvanced f = new FormAdvanced();
            f.Show();
        }
    }
}
