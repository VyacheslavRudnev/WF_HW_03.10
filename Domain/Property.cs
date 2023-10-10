using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Domain
{
    public class Property
    {
        public string PropertyType { get; set; }
        public decimal PropertyValue { get; set; }
        public double PropertyArea { get; set; }
        public Property(string propertyType, decimal propertyValue, double propertyArea)
        {
            PropertyType = propertyType;
            PropertyValue = propertyValue;
            PropertyArea = propertyArea;
        }
        public Property()
        {
            PropertyType = "";
            PropertyValue = 0;
            PropertyArea = 0;
        }
        public override string ToString()
        {
            return $"Нерухомість {PropertyType} площею {PropertyArea} кв.м.";
        }
    }
}
