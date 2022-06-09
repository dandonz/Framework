using System.IO;
using System.Collections.Generic; 
namespace Utility
{
    public class FileHelper: IDataHelper<string>
    {
        public List<string> ReadData(string file)
        {
            List<string> lines = new List<string>(); 
            using(StreamReader sr = new StreamReader(file)){
                string line; 
                while((line = sr.ReadLine())!=null){
                    lines.Add(line);
                }
            }
            return lines;
        }
        public void WriteData(List<string> data, string file)
        {
            using(StreamWriter sw = new StreamWriter(file)){
                foreach(string line in data){
                    sw.WriteLine(line);
                }
            }
        }
    }



}