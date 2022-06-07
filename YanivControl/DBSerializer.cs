using CarClassDB.Entity;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace CarInterface
{
    // ToDo: #4 Util class to do serialization and deserialization 
    public static class DBSerializer
    {
        
        public static List<Entity> read(string filename)
        {
            List<Entity> result = new List<Entity>();
            switch(filename.Substring(filename.Length - 4))
            {
                case ".xml":
                    result = readXML(filename);
                    break;
                case "json":
                    result = readJSON(filename);
                    break;
                case ".dat":
                    result = readDAT(filename);
                    break;
            }
            return result;
        }
        public static void write(string filename, List<Entity> writeList)
        {
            switch (filename.Substring(filename.Length - 4))
            {
                case ".xml":
                    writeXML(filename, writeList);
                    break;
                case "json":
                    writeJSON(filename,writeList);
                    break;
                case ".dat":
                    writeDAT(filename,writeList);
                    break;
            }
        }

        public static void writeJSON(string filename, List<Entity> writeList)
        {
            using (TextWriter fs = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.TypeNameHandling = TypeNameHandling.All;
                serializer.Serialize(fs, writeList);
            }
        }

        public static List<Entity> readJSON(string filename)
        {
            List<Entity> result = new List<Entity>();
            using (Stream Stream = new FileStream(filename, FileMode.Open))
            using (StreamReader SR = new StreamReader(Stream))
            using (JsonTextReader file = new JsonTextReader(SR))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.TypeNameHandling = TypeNameHandling.All;
                result = serializer.Deserialize<List<Entity>>(file);
            }

            return result;
        }

        public static void writeXML(string filename, List<Entity> writeList)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Entity>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                ser.Serialize(fs, writeList);
            }
        }

        public static List<Entity> readXML(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<Entity>));
            List<Entity> result = new List<Entity>();
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                result = (List<Entity>) ser.Deserialize(reader);
            }
            return result;
        }

        public static void writeDAT(string filename, List<Entity> writeList)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, writeList);
            }
        }
        public static List<Entity> readDAT(string filename)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<Entity> result;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                result = (List<Entity>)formatter.Deserialize(fs);
            }
            return result;
        }
    }
}
