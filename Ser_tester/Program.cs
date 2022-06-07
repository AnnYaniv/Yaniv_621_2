using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CarClassDB;
using CarClassDB.Entity;
using CarInterface;

namespace Ser_tester
{
    class Program
    {
        static DB database = DB.getInstance();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Auto a1, a2;
            a1 = create_auto("a3333");
            a2 = create_auto("a4444");
            
            database.add(a1);
            database.add(a1);
            database.add(a2);
            Drivers dr = new Drivers();
            dr.id = 1;

            List<Entity> to_Serialize;
            to_Serialize = DBSerializer.read("C:\\Users\\yaniv\\source\\repos\\Yaniv_621_2\\YanivForm\\bin\\Debug\\i_hate_this_sm.json");

            foreach (Entity a in to_Serialize)
            {
                Auto b = (Auto)a;
                Console.WriteLine(b.carNum);
            }
            /*
            XmlSerializer ser = new XmlSerializer(typeof(List<Entity>));
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, writeList);
            writer.Close();*/
        }
        public static void readFrom(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DB));
            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                database = (DB)ser.Deserialize(reader);
            }
        }

        public static void write(string filename)
        {
            XmlSerializer ser = new XmlSerializer(typeof(DB));
            TextWriter writer = new StreamWriter(filename);
            ser.Serialize(writer, database);
            writer.Close();
        }

        static public Auto create_auto(string number)
        {
            Auto a = new Auto();
            a.brand="Audi";
            a.carNum = number;
            a.type = carType.BUS;
            return a;
        }
    }
}
