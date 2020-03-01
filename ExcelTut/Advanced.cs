using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelTut
{
    public partial class FormAdvanced : Form
    {
        public FormAdvanced()
        {
            InitializeComponent();
        }
        public string connString = "Server=DESKTOP-EHCH26F\\SQLEXPRESS;Database=Excel;Trusted_Connection=True";

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if(textBoxConnString.Text != "")
            {
            textBoxConnString.Text = connString;
            }
            Excel ex = new Excel();
            ex.ConnectionString = connString;
            textBoxConnString.Clear();
        }
        
    }
}
