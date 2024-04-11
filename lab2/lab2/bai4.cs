using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace lab2
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_in4 in4 = new student_in4();
            in4.ShowDialog();
        }
        public void CreateExcel(string[] lines)
        {
            
            Excel.Application xlApp = new Excel.Application();

            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells[1, 1] = "MSSV";
            xlWorkSheet.Cells[1, 2] = "Họ tên";
            xlWorkSheet.Cells[1, 3] = "SĐT";
            xlWorkSheet.Cells[1, 4] = "Toán";
            xlWorkSheet.Cells[1, 5] = "Văn";
            xlWorkSheet.Cells[1, 6] = "ĐTB";
            for (int i = 2; i <= lines.Length + 1; i++)
            {
                string[] line = lines[i - 2].Split(';');

                xlWorkSheet.Cells[i, 1] = line[0];
                xlWorkSheet.Cells[i, 2] = line[1];
                xlWorkSheet.Cells[i, 3] = line[2];
                xlWorkSheet.Cells[i, 4] = line[3];
                xlWorkSheet.Cells[i, 5] = line[4];
                float dtb = (float.Parse(line[3]) + float.Parse(line[4])) / 2;
                xlWorkSheet.Cells[i, 6] = dtb.ToString();
            }

            //Here saving the file in xlsx
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.SelectedPath + "/input.xlsx"; 
                xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
                misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                Marshal.ReleaseComObject(xlWorkSheet);
                Marshal.ReleaseComObject(xlWorkBook);
                Marshal.ReleaseComObject(xlApp);
                MessageBox.Show("File input.xlsx created!!!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string content;
            try
            {
                FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                Byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, (int)fs.Length);
                content = Encoding.UTF8.GetString(bytes);
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Please enter data first!");
                return;
            }
            
            string[] lines = content.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            CreateExcel(lines);
        }
        public class Student
        {

            public string id { get; set; }
            public string name { get; set; }
            public string phone { get; set; }
            public string math { get; set; }
            public string literature { get; set; }
            public string average { get; set; }
            public Student(string id, string name, string phone, string math, string literature, string average)
            {
                this.id = id;
                this.name = name;
                this.phone = phone;
                this.math = math;
                this.literature = literature;
                this.average = average;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (file.ShowDialog() == DialogResult.OK)
            {
                string path = file.FileName;
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                Student[] students = new Student[rowCount - 1];
                for (int j = 2; j <= rowCount; j++)
                {
                    Student s = new Student(xlRange.Cells[j, 1].Value2.ToString(), xlRange.Cells[j, 2].Value2.ToString(), xlRange.Cells[j, 3].Value2.ToString(), xlRange.Cells[j, 4].Value2.ToString(), xlRange.Cells[j, 5].Value2.ToString(), xlRange.Cells[j, 6].Value2.ToString());
                    students[j - 2] = s;
                }
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
                dataGridView1.DataSource = students;

            }
        }
    }
}
