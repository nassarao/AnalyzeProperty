using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PropertyAnalyzerLib
{
    public class Property
    {
        public string PropertyType { get; set; }
        public Address Address { get; set; }
        public double PropertyTax { get; set; }
        public int UnitCount { get; set; }


        public Property(Address address, string propertyType)
        {
            Address = address;
            PropertyType = propertyType;

            if (PropertyType == PropertyTypes.SINGLE_FAMILY)
                UnitCount = 1;
            else if (PropertyType == PropertyTypes.DUPLEX)
                UnitCount = 2;
            else if (PropertyType == PropertyTypes.TRIPLEX)
                UnitCount = 3;
            else if (PropertyType == PropertyTypes.QUADPLEX)
                UnitCount = 4;
            
        }





        override
        public string ToString()
        {
            return String.Format("Property Details|Address: {0}|Property Type: {1}|Unit Count: {2}|Property Tax:{3}",
                Address.ToString(), PropertyType, UnitCount, PropertyTax);
        }
    }


    public class Address
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }

        public Address(string streetNum, string streetName, string city, string zip, string state)
        {
            StreetNumber = streetNum;
            StreetName = streetName;
            City = city;
            Zip = zip;
            State = state;
        }

        override
        public string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", StreetNumber, StreetName, City, State, Zip);

        }
    }
    public static class PropertyTypes
    {

        public static string SINGLE_FAMILY = "Single Family";
        public static string DUPLEX = "Duplex";
        public static string TRIPLEX = "Triplex";
        public static string QUADPLEX = "Quadplex";
        public static string APARTMNET_BUILDING = "Apartment building";

    }
}
