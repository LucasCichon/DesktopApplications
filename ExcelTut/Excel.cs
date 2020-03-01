using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace ExcelTut
{
    class Excel
    {
        string path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public string ConnectionString;

        public Excel() { } //konstruktor bez parametrów

        public Excel(string path, int Sheet) //konstruktor (jako parametry przyjmuje scieżkę do pliku oraz numer arkusza)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path); //zmiennej Workbook przypisujemy wartość pobraną z pliku
            ws = wb.Worksheets[Sheet];      //zmienna WorkSheet przyjmuje wartość konkretnego arkusza o numerze Sheet podanego podczas wywołania konstruktora
        }



        public string ReadCell(int i, int j) //metoda odczytująca dane z arkusza
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null) //jeżeli w komórce [i,j] jest wartość, zwracamy wartość
            {
                return ws.Cells[i, j].Value2;
            }
            else return "";
        }
        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet); //tworzymy nowy obiekt pliku
            this.ws = wb.Worksheets[1];
        }

        public void CreateNewSheet()
        {
            Worksheet templateSheet = wb.Worksheets.Add(After: ws);
        }

        public void WriteToCell(int i, int j, string s)
        {
            //i++;
            //j++;
            ws.Cells[i, j].Value2 = s;
        }
        public void Save()
        {
            wb.Save();
        }
        public void SaveAs(string path)
        {
            wb.SaveAs(path); 
        }
        public void SelectWorksheet(int SheetNumber)
        {
            this.ws = wb.Worksheets[SheetNumber];
        }
        public void DeleteWorksheet(int SheetNumber)
        {
            this.wb.Worksheets[SheetNumber].Delete();
        }
        public void Close()
        {
            wb.Close();
        }
    }
}
