using CarClassDB.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace CarInterface
{
    public static class DBSerializer
    {
        
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

            using (JsonTextReader file = new JsonTextReader(File.OpenText(filename)))
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
