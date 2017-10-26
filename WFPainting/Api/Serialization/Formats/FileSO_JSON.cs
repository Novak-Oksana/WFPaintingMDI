using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFPainting.Api
{
    public class FileSO_JSON : IFileSO
    {
        string path = "";

        public FileSO_JSON(string path)
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
            string jsonString = File.ReadAllText(path);
            List<TabMemento> mementoList = new List<TabMemento>();
            if (jsonString.Length != 0)
                mementoList = JsonConvert.DeserializeObject<List < TabMemento >> (jsonString);

            return mementoList;
        }

        public void Save(List<TabMemento> saveList)
        {
            string jsonString = JsonConvert.SerializeObject(saveList);
            File.WriteAllText(path, jsonString);
        }
    }
}