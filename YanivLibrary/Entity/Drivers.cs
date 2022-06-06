using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassDB
{
    public class Drivers
    {
        [DisplayName("Id Driver")] public int id { get; set; }
        [DisplayName("Passport")] public String passportSeries { get; set; }
        [DisplayName("Passport")] public int passport { get; set; }
        [DisplayName("Surname")] public String surname { get; set; }
        [DisplayName("Name")] public String name { get; set; }
        [DisplayName("Patronymic")] public String patronymic { get; set; }
        [DisplayName("Date of receipt")] public String receipt { get; set; }
        [DisplayName("Category")] public categoryType category { get; set; }
    }
}
