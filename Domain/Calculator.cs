using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp3.Domain
{
    public class Calculator
    {
        public decimal baseInsCascoRate = 3.50m;
        public decimal baseInsOscpvRate = 2191.0m;
        public decimal baseInsDcv = 440.0m;
        public decimal basePropertyRate = 0.0m;
        public decimal EcoPropertyRate = 550.0m;
        public decimal StandardPropertyRate = 990.0m;
        public decimal BonusPropertyRate = 1870.0m;
        public decimal baseInsTravelRate = 22.50m;

        

        public decimal CascoIns(int year, decimal value)
        {
            try
            {
                decimal CascoRate = baseInsCascoRate;
                if (year >= 2019)
                {
                    return CascoRate = CascoRate * value / 100;
                }
                else if (year < 2019 && year >= 2017)
                {
                    return CascoRate = CascoRate * value * 1.2m / 100;
                }
                else if (year < 2017 && year >= 2015)
                {
                    return CascoRate = CascoRate * value * 1.4m / 100;
                }
                MessageBox.Show("Страхування авто віком понад 10 років неможливе", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public decimal OscpvIns(double value)
        {
            if (value <= 1.6)
            {
                return baseInsOscpvRate;
            }
            else if (value > 1.6 && value <= 2.0)
            {
                return baseInsOscpvRate * 1.1m;
            }
            else if (value > 2.0 && value <= 3.0)
            {
                return baseInsOscpvRate * 1.25m;
            }
            else
            {
                return baseInsOscpvRate * 1.4m;
            }
        }
        public decimal DcvIns()
        {
            return baseInsDcv;
        }
        public decimal PropertyIns(int button)
        {
            if (button == 1)
            {
                return EcoPropertyRate;
            }
            else if (button == 2)
            {
                return StandardPropertyRate;
            }
            else if (button == 3)
            {
                return  BonusPropertyRate;
            }
            return basePropertyRate;
        }
        public decimal TravelIns(int days, int travelers, int cover, int button)
        {
           
            if ( button == 1)
            {
                decimal TravelRate = baseInsTravelRate * 1.0m * days * travelers;
                if (cover == 10000)
                {
                    return TravelRate * 1.1m;
                }
                else if (cover == 20000)
                {
                    return TravelRate * 1.2m;
                }
                else if (cover == 30000)
                {
                    return TravelRate * 1.3m;
                }
                else if (cover == 40000)
                {
                    return TravelRate * 1.4m;
                }
                else if (cover == 50000)
                {
                    return TravelRate * 1.5m;
                }
                else if (cover == 60000)
                {
                    return TravelRate * 1.6m;
                }
                else if (cover == 70000)
                {
                    return TravelRate * 1.7m;
                }
                return TravelRate * 1.8m;
            }
            else if (button ==2)
            {
                decimal TravelRate = baseInsTravelRate * 1.15m * days * travelers;
                if (cover == 10000)
                {
                    return TravelRate * 1.1m;
                }
                else if (cover == 20000)
                {
                    return TravelRate * 1.2m;
                }
                else if (cover == 30000)
                {
                    return TravelRate * 1.3m;
                }
                else if (cover == 40000)
                {
                    return TravelRate * 1.4m;
                }
                else if (cover == 50000)
                {
                    return TravelRate * 1.5m;
                }
                else if (cover == 60000)
                {
                    return TravelRate * 1.6m;
                }
                else if (cover == 70000)
                {
                    return TravelRate * 1.7m;
                }
                return TravelRate * 1.8m;
            }
            else if (button ==3)
            {
                decimal TravelRate = baseInsTravelRate * 1.22m * days * travelers;
                if (cover == 10000)
                {
                    return TravelRate * 1.1m;
                }
                else if (cover == 20000)
                {
                    return TravelRate * 1.2m;
                }
                else if (cover == 30000)
                {
                    return TravelRate * 1.3m;
                }
                else if (cover == 40000)
                {
                    return TravelRate * 1.4m;
                }
                else if (cover == 50000)
                {
                    return TravelRate * 1.5m;
                }
                else if (cover == 60000)
                {
                    return TravelRate * 1.6m;
                }
                else if (cover == 70000)
                {
                    return TravelRate * 1.7m;
                }
                return TravelRate * 1.8m;
            }
            return 0;
            
        }

    }
}
