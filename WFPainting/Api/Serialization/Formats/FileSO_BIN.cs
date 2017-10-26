using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WFPainting.Api
{
    public class FileSO_BIN : IFileSO
    {
        string path = "";

        public FileSO_BIN(string path)
        {
            this.path = path;
        }

        public List<TabMemento> Open()
        {
            if (File.Exists(path) == false)
            {
                FileStream stream = File.Create(path);
                stream.Close();
                return new List<TabMemento>();
            }
            List<TabMemento> mementoList = new List<TabMemento>();
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                mementoList = (List<TabMemento>)formatter.Deserialize(stream);
            }
            return mementoList;
        }

        public void Save(List<TabMemento> saveList)
        {
            using (Stream stream = File.Open(path, FileMode.Create))
            {
                new BinaryFormatter().Serialize(stream, saveList);
            }
        }
    }
}