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

namespace ExcelTut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        public void Form1_Load() //To tutaj jest chyba nie potrzebne
        {
            Excel excel = new Excel(@"Create",2); // tworzymy obiek wywołując konstruktor bez parametrów
            //excel.CreateNewFile(); //tworzymy nowy plik
            //excel.CreateNewSheet();
            excel.SelectWorksheet(2);
            excel.WriteToCell(1, 1, "Ale czadowo");
            excel.DeleteWorksheet(1);
            excel.Save(); //zapisujemy 
            excel.Close();  //zamykamy
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.TextBox_Path.Text = openFileDialog1.FileName;
            }
        }

        private void btnSheet_Click(object sender, EventArgs e)
        {
            string path = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + TextBox_Path + ";Extend Properties = \"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(path);

            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * From [" + TextBox_Sheet.Text + "$]", conn);

            DataTable dt = new DataTable();
            myDataAdapter.Fill(dt);
            dgvList.DataSource = dt;
        }
    }
}
