using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CarClassDB
{
    public class Viezd
    {
        [DisplayName("Date of start travel")] public String dateViezd { get; set; }
        [DisplayName("Driver Id")] public int driverId { get; set; }
        [DisplayName("Car number")] public String carNum { get; set; }
        [DisplayName("Distance")] public int km { get; set; }
    }
}
