using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace CarClassDB
{
    
    [Serializable]
    public class Viezd : Entity.Entity, ISerializable
    {
        [DisplayName("Date of start travel")] public String dateViezd { get; set; }
        [DisplayName("Driver Id")] public int driverId { get; set; }
        [DisplayName("Car number")] public String carNum { get; set; }
        [DisplayName("Distance")] public int km { get; set; }
        // ToDo: #4 Code below - for serialization and deseriliazation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("dateViezd", this.dateViezd);
            info.AddValue("driverId", this.driverId);
            info.AddValue("carNum", this.carNum);
            info.AddValue("km", this.km);
        }
        public Viezd() { }

        public Viezd(SerializationInfo info, StreamingContext context)
        {

            dateViezd = info.GetString(nameof(dateViezd));
            driverId = Convert.ToInt32(info.GetString(nameof(driverId)));
            carNum = info.GetString(nameof(carNum));
            km = Convert.ToInt32(info.GetString(nameof(km)));

        }
    }
}
