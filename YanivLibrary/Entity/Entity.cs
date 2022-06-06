using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace CarClassDB.Entity
{
    
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Drivers))]
    [XmlInclude(typeof(Viezd))]
    [Serializable]
    public class Entity : ISerializable
    {
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
