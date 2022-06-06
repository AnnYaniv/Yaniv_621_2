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
    public class Drivers : Entity.Entity, ISerializable
    {
        [DisplayName("Id Driver")] public int id { get; set; }
        [DisplayName("Passport")] public String passportSeries { get; set; }
        [DisplayName("Passport")] public int passport { get; set; }
        [DisplayName("Surname")] public String surname { get; set; }
        [DisplayName("Name")] public String name { get; set; }
        [DisplayName("Patronymic")] public String patronymic { get; set; }
        [DisplayName("Date of receipt")] public String receipt { get; set; }
        [DisplayName("Category")] public categoryType category { get; set; }
        // ToDo: #4 Code below - for serialization and deseriliazation
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id", this.id);
            info.AddValue("passportSeries", this.passportSeries);
            info.AddValue("passport", this.passport);
            info.AddValue("surname", this.surname);
            info.AddValue("name", this.name);
            info.AddValue("patronymic", this.patronymic);
            info.AddValue("receipt", this.receipt);
            info.AddValue("category", this.category);
        }

        public Drivers() { }
        public Drivers(SerializationInfo info, StreamingContext context)
        {
            id = Convert.ToInt32(info.GetString(nameof(id)));
            passportSeries = info.GetString(nameof(passportSeries));
            passport = Convert.ToInt32(info.GetString(nameof(passport)));

            surname = info.GetString(nameof(surname));
            name = info.GetString(nameof(name));
            patronymic = info.GetString(nameof(patronymic));

            receipt = info.GetString(nameof(receipt));

            string typeStr = info.GetString(nameof(category));
            if (Enum.IsDefined(typeof(categoryType), typeStr))
            {
                category = (categoryType)Enum.Parse(typeof(categoryType), typeStr);
            }
        }
    }
}
