using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace WFPainting.Api
{
    public class FileSO_YAML : IFileSO
    {
        string path = "";

        public FileSO_YAML(string path)
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
            string yamlString = File.ReadAllText(path);
            List<TabMemento> mementoList = new List<TabMemento>();
            Deserializer deserializer = new Deserializer();
            if (yamlString.Length != 0)
                mementoList = deserializer.Deserialize<List<TabMemento>>(yamlString);

            return mementoList;
        }

        public void Save(List<TabMemento> saveList)
        {
            Serializer serializer = new Serializer();
            string yamlString = serializer.Serialize(saveList);//
            File.WriteAllText(path, yamlString);
        }
    }
}