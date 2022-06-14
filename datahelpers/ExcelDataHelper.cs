//For Java, use Apache POI
//For C#, use Excel Data Helper and Dataset
//To read and write data to excel, first, create a class to hold all columns in excel. 
using ExcelDataReader;
using System.Data; 
using System.Collections;
using System.Collections.Generic;  


namespace Utility
{
    public class ExcelDataHelper: IDataHelper<string>
    {
         public List<string> ReadData(string file)
         {
            List<string> list = new List<string>();
            return list; 

         }
          public void WriteData(List<string> data, string file)
          {
            return; 
          }
    }
}