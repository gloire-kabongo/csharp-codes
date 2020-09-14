using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace XmlSerialisationExemple
{
    class Program
    {
        static void Main(string[] args)
        {
            var purchaseOrder = new PurchaseOrder
            {
                Address = new Address{ AddressLine = "Msiri" },
                Items = new OrderItem[]
                {
                    new OrderItem{ Name = "iPhone"},
                    new OrderItem { Name = "Surface Duo"}
                }
            };
            //Serilisation<PurchaseOrder>(purchaseOrder);

            //JsonConvert.SerializeObject(purchaseOrder);
            //JsonSerialisation(purchaseOrder);

            File.WriteAllText(@"C:\Dev\Files\purchaseorder.json",
                JsonConvert.SerializeObject(purchaseOrder));
        }

        static void JsonSerialisation(PurchaseOrder purchaseOrder)
        {
            JsonSerializer serializer = new JsonSerializer();
            StreamWriter stream =
                File.CreateText(@"C:\Dev\Files\purchaseorder.json");
            serializer.Serialize(stream, purchaseOrder);
        }

        static void Serilisation<T>(T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            // Serialization
            FileStream stream =
                new FileStream(@"C:\Dev\Files\Course.xml",
                    FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

        }

        static T Deserialisation<T>()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            var stream = new FileStream(@"C:\Dev\Files\Course.xml", FileMode.Open, FileAccess.Read);
            if(formatter.Deserialize(stream) is T obj)
                return obj;
            else return default(T);

        }
    }
}
