using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace SimpleBrowser
{
    class GetData
    {
        public string GetMetaData(string searchString)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str;
            int rowCount;
            int columnCount;
            int row = 0;
            int column = 0;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\Babu\Desktop\data.xlsx", 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            row= range.Rows.Count;
            column = range.Columns.Count;
            string key = "";
            string value = "";
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (rowCount = 1; rowCount <= row; rowCount++)
            {
                for (columnCount = 1; columnCount <=column; columnCount++)
                {
                    str = (string)(range.Cells[rowCount, columnCount] as Excel.Range).Value2;
                    if(columnCount==1)
                    {
                        key = str;
                        continue;
                    }
                    else
                    {
                        value = str;
                    }
                    
                }
                dict.Add(key, value);
            }
            string result="";
          foreach(KeyValuePair<string,string> entry in dict)
            {
                if (entry.Key.Contains(searchString)) result = entry.Value;
            }
            return result;
        }
    }
}
