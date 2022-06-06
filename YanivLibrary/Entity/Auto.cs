using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarClassDB
{
    
    [Serializable]
    public partial class Auto : Entity.Entity, ISerializable 
    {
        [DisplayName ("Car number")] public String carNum { get; set; }
        [DisplayName("Car brand")] public String brand { get; set; }
        [DisplayName("Type of car")] public carType type { get; set; }
        [DisplayName("Year of manufacture")] public int date { get; set; }
        [DisplayName("Engine power")] public int power { get; set; }
        [DisplayName("Fuel consumption")] public int fuelConsumption { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("carNum", this.carNum);
            info.AddValue("brand", this.brand);
            info.AddValue("type", this.type);
            info.AddValue("date", this.date);
            info.AddValue("power", this.power);
            info.AddValue("fuelConsumption", this.fuelConsumption);
        }
        // ToDo: #4 Code below - for serialization and deseriliazation
        public Auto() { }
        public Auto(SerializationInfo info, StreamingContext context)
        {
            carNum = info.GetString(nameof(carNum));
            brand = info.GetString(nameof(brand));
            string typeStr = info.GetString(nameof(type));
            if(Enum.IsDefined(typeof(carType), typeStr))
            {
                type = (carType)Enum.Parse(typeof(carType),typeStr);
            }

            date = Convert.ToInt32(info.GetString(nameof(date)));
            power = Convert.ToInt32(info.GetString(nameof(power)));
            fuelConsumption = Convert.ToInt32(info.GetString(nameof(fuelConsumption)));
        }

        
    }
}
