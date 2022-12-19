using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;

namespace FirstSupply_Scraper
{
    internal class ExcelHelper
    {
        public string getFilePath()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;
            else
                return "failed";
        }

        public void readExcel(List<Product> prod)
        {
            using (var stream = File.Open(getFilePath(), FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            prod.Add(new Product(reader.GetString(6), reader.GetString(5)));
                        }
                    } while (reader.NextResult());
                }
            }
        }

        public void writeExcel(List<Product> prod)
        {
            Excel.Application xlApp = new Excel.Application();
            object misValue = System.Reflection.Missing.Value;
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Add();
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            xlWorksheet.Columns[1].NumberFormat = "@";

            xlWorksheet.Cells[1, 1] = "Category Tree";
            xlWorksheet.Cells[1, 2] = "Category 1";
            xlWorksheet.Cells[1, 3] = "Category 2";
            xlWorksheet.Cells[1, 4] = "Category 3";
            xlWorksheet.Cells[1, 5] = "Category 4";
            xlWorksheet.Cells[1, 6] = "Category 5";
            xlWorksheet.Cells[1, 7] = "Category 6";
            xlWorksheet.Cells[1, 8] = "Product Number";
            int i = 2;
            foreach (Product p in prod)
            {
                for (int j = 1; j <= 8; j++)
                {
                    switch (j)
                    {
                        case 1:
                            xlWorksheet.Cells[i, j] = p.catTree;
                            break;
                        case 2:
                            xlWorksheet.Cells[i, j] = p.cat1;
                            break;
                        case 3:
                            xlWorksheet.Cells[i, j] = p.cat2;
                            break;
                        case 4:
                            xlWorksheet.Cells[i, j] = p.cat3;
                            break;
                        case 5:
                            xlWorksheet.Cells[i, j] = p.cat4;
                            break;
                        case 6:
                            xlWorksheet.Cells[i, j] = p.cat5;
                            break;
                        case 8:
                            xlWorksheet.Cells[i, j] = p.prodNum;
                            break;
                        default:
                            xlWorksheet.Cells[i, j] = "Error";
                            break;
                    }
                }
                i++;
            }
            xlWorkbook.SaveAs2(@"D:\FirstSupplyScraper\output.xls", Excel.XlFileFormat.xlWorkbookNormal);
            xlWorkbook.Close();
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorksheet);
            Marshal.ReleaseComObject(xlWorkbook);
            Marshal.ReleaseComObject(xlApp);

        }
    }
}
