using System;
using System.Xml.Serialization;

namespace XmlSerialisationExemple
{
    [Serializable]
    public class PurchaseOrder
    {
        public Address Address;
        public OrderItem[] Items;
    }

    public class Address
    {
        [XmlAttribute]
        public string AddressLine;
    }

    public class OrderItem
    {
        public string Name;
    }
}