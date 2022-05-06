using System.Collections.Generic; 
namespace Utility
{
    public interface IDataHelper<T>
    {
        List<T> ReadData(string file);
        void WriteData(List<T> data, string file);
    }
}
