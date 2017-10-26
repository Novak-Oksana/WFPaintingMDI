using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace WFPainting.Api
{
    public class FileSO_XML : IFileSO
    {
        string path = "";

        public FileSO_XML(string path)
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
            TextReader reader = File.OpenText(path);

            XmlSerializer serializer = new XmlSerializer(typeof(List<TabMemento>));//Exception!!!
            List<TabMemento> mementoList = new List<TabMemento>();
            try
            {
                mementoList = (List<TabMemento>)serializer.Deserialize(reader);
            }
            catch (Exception)
            {
                mementoList = new List<TabMemento>();
            }

            reader.Close();
            return mementoList;
        }

        public void Save(List<TabMemento> saveList)
        {
            TextWriter writer = File.CreateText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<TabMemento>));
            serializer.Serialize(writer, saveList);
            writer.Close();
        }
    }
}