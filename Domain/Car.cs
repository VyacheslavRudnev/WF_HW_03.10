using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Domain
{
    public class Car
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public int CarYear { get; set; }
        public decimal MarketValue { get; set; }
        public double EngineVal { get; set; }
        public Car(string carBrand, string carModel, int carYear, decimal marketValue, double engineVal)
        {
            CarBrand = carBrand;
            CarModel = carModel;
            CarYear = carYear;
            MarketValue = marketValue;
            EngineVal = engineVal;
        }
        public Car()
        {
            CarBrand = "";
            CarModel = "";
            CarYear = 0;
            MarketValue = 0;
            EngineVal = 0;
        }
        public override string ToString()
        {
            return $"Авто {CarBrand} {CarModel} {CarYear} року випуску";
        }
    }
}
