using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassDB
{
    public partial class Auto
    {
        [DisplayName ("Car number")] public String carNum { get; set; }
        [DisplayName("Car brand")] public String brand { get; set; }
        [DisplayName("Type of car")] public carType type { get; set; }
        [DisplayName("Year of manufacture")] public int date { get; set; }
        [DisplayName("Engine power")] public int power { get; set; }
        [DisplayName("Fuel consumption")] public int fuelConsumption { get; set; }
    }
}
