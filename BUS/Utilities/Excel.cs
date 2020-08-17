

using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utilities
{
    public class Excel
    {
        public static DataTableCollection readFile(String fileName) 
        {
            FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read);
            using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs))
            {
                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                    {
                        UseHeaderRow = true
                    }
                });
                return result.Tables;
            }
           
        }
    }
}
