using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using CarClassDB;
using CarClassDB.Entity;
using CarInterface;

namespace Ser_tester
{
    [Serializable]
    class qwerty : ISerializable
    {
        private Auto[] _auto;
        private Drivers[] _drivers;
        private Viezd[] _viezd;

        public qwerty()
        {
            Auto a1, a2;
            a1 = create_auto("a3333");
            a2 = create_auto("a4444");
            Auto[] a = { a1, a2 };
            _auto = a;
            _drivers = new Drivers[2];
            _viezd = new Viezd[1];
        }
        public Auto create_auto(string number)
        {
            Auto a = new Auto();
            a.brand = "Audi";
            a.carNum = number;
            a.type = carType.BUS;
            return a;
        }
        public qwerty(SerializationInfo info, StreamingContext context)
        {
            _auto = (Auto[])info.GetValue(nameof(_auto), typeof(Auto[]));
            _drivers = (Drivers[])info.GetValue(nameof(_drivers), typeof(Drivers[]));
            _viezd = (Viezd[])info.GetValue(nameof(_viezd), typeof(Viezd[]));

        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_auto", this._auto);
            info.AddValue("_drivers", this._drivers);
            info.AddValue("_viezd", this._viezd);
        }
    }

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

            //database.add(dr);
            foreach (Entity a in database.toEntList())
            {
                Console.WriteLine(a);
            }
            List<Entity> to_Serialize;
            List<Entity> to_Serialize_1 = database.toEntList();
            Console.WriteLine( JsonSerializer.Serialize(to_Serialize_1));

            //DBSerializer.writeJSON("i_hate_this_sm.json", to_Serialize_1);
            //to_Serialize = DBSerializer.readJSON("i_hate_this_sm.json");

            DBSerializer.writeDAT("data.dat", to_Serialize_1);
            to_Serialize = DBSerializer.readDAT("data.dat");
            /*to_Serialize = DBSerializer.readXML("i_hate_this_sm.json");*/
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
