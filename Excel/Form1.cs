using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static void excelsave()
            {
                try
                {
                    Application app = new Application();
                    string execPath =
                      Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                    Workbook book = app.Workbooks.Open(@"c:\test.xls");
                    Worksheet sheet = (Worksheet)book.Worksheets[1];

                    Range range = sheet.get_Range("A1");
                    range.Columns.ColumnWidth = 22.34;
                    range = sheet.get_Range("B1");
                    range.Columns.ColumnWidth = 22.34;

                    sheet.get_Range("A1", "B1").Font.Bold = true;

                    book.SaveAs(@"c:\test2.xls");  // or book.Save();
                    book.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}
