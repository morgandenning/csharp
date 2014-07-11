using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Runtime.Serialization.Json;

namespace Engine.Classes
{
    [Serializable]
    public class SerializeJSON
    {
        
        [NonSerialized]
        public SerializeJSON circularReference;

        public static void Serialize(SerializeJSON obj, Stream stream)
        {
            
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SerializeJSON));
            js.WriteObject(stream, obj);
        }

        public static SerializeJSON DeSerialize(Stream stream)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SerializeJSON));
            return (SerializeJSON)js.ReadObject(stream);
        }
    }
}



