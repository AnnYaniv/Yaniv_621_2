using CarClassDB;
using CarClassDB.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CarInterface
{
    public class DB 
    {
        
        private List<Viezd> viezds_table = new List<Viezd>();
        private List<Drivers> drivers_table = new List<Drivers>();
        private List<Auto> autos_table = new List<Auto>();
        private ConfigReader conf = ConfigReader.getInstance();
        private static DB database = null;

        private DB() {
            
        }

        
        public static DB getInstance()
        {
            if (database == null) database = new DB();
            return database;
        }

        // ToDo: #3 rewrite method to using prop-s from ConfigReader class
        public bool add(Object element)
        {
            if (element.GetType() == typeof(Auto))
            {
                autos_table.Add((Auto)element);
                return true;
            }
            if (element.GetType() == typeof(Drivers))
            {
                drivers_table.Add((Drivers)element);
                return true;
            }
            if (element.GetType() == typeof(Viezd))
            {
                if (!conf.AllowAddWithFK) return false; 
                viezds_table.Add((Viezd)element);
                return true;
            }
            return false;
        }


        public Auto getAuto(String car_number)
        {
            if (car_number == null) return null;
            foreach(Auto a in autos_table)
            {
                if (a.carNum == car_number) return a;
            }
            return null;
        }
        public Drivers getDriver(int id)
        {
            foreach (Drivers a in drivers_table)
            {
                if (a.id == id) return a;
            }
            return null;
        }
        public Viezd getViezd(String date, int driveId, string carNumber)
        {
            foreach (Viezd a in viezds_table)
            {
                if ((a.dateViezd == date)&&(a.driverId == driveId)&&(a.carNum == carNumber)) return a;
            }
            return null;
        }
        
        // ToDo: #3 rewrite method to using prop-s from ConfigReader class and do cascade deleting
        public bool delete(object element)
        {
            if (element.GetType() == typeof(Auto))
            {
                Auto auto = (Auto)element;
                List<Viezd> existed = viezds_table.FindAll(viezd => viezd.carNum == auto.carNum);

                if (!conf.AllowDeleteWithFK && (existed.Count > 0)) return false;
                else
                {
                    autos_table.Remove((Auto)element);
                    foreach (Viezd v in existed)
                    {
                        viezds_table.Remove(v);
                    }
                }
            }
            if (element.GetType() == typeof(Drivers))
            {
                Drivers driver = (Drivers)element;
                List<Viezd> existed = viezds_table.FindAll(viezd => viezd.driverId == driver.id);

                if (!conf.AllowDeleteWithFK && (existed.Count > 0)) return false;
                else
                {
                    drivers_table.Remove((Drivers)element);
                    foreach (Viezd v in existed)
                    {
                        viezds_table.Remove(v);
                    }
                }
            }
            if (element.GetType() == typeof(Viezd))
            {
                viezds_table.Remove((Viezd)element);
            }
            return true;
        }

        public Auto getAutoByIndex(int i)
        {
            return autos_table.ElementAt(i);
        }
        public Drivers getDriversByIndex(int i)
        {
            return drivers_table.ElementAt(i);
        }
        public Viezd getViezdByIndex(int i)
        {
            return viezds_table.ElementAt(i);
        }

        public int getSize(Type a)
        {
            if(a == typeof(Auto))
            {
                return autos_table.Count;
            }
            if (a == typeof(Drivers))
            {
                return drivers_table.Count;
            }
            if (a == typeof(Viezd))
            {
                return viezds_table.Count;
            }
            return 0;
        }

        public List<Auto> AutoSource()
        {
            return autos_table;
        }
        public List<Drivers> DriversSource()
        {
            return drivers_table;
        }
        public List<Viezd> ViezdSource()
        {
            return viezds_table;
        }
        // ToDo: #4 code below helps DBSerializer.cs to do serialization and deserializations things
        public List<Entity> toEntList()
        {
            List<Entity> all_entities = new List<Entity>();
            foreach (Auto a in autos_table)
                all_entities.Add(a);
            foreach (Drivers a in drivers_table)
                all_entities.Add(a);
            foreach (Viezd a in viezds_table)
                all_entities.Add(a);
            return all_entities;
        }
        public void SeparateList(List<Entity> all_entities)
        {
            autos_table.Clear();
            drivers_table.Clear();
            viezds_table.Clear();
            foreach (Entity e in all_entities)
                add(e);
        }
    }
}
