using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Domain
{
    public class Journeys
    {
        public string JourneyCountry { get; set; }
        public decimal JourneyInsCover { get; set; }
        public int JourneyDays { get; set; }
        public int JourneyPeople { get; set; }
       
        public Journeys(string journeyCountry, decimal journeyInsCover, int journeyDays, int journeyPeople)
        {
            JourneyCountry = journeyCountry;
            JourneyInsCover = journeyInsCover;
            JourneyDays = journeyDays;
            JourneyPeople = journeyPeople;
        }
        public Journeys()
        {
            JourneyCountry = "";
            JourneyInsCover = 0;
            JourneyDays = 0;
            JourneyPeople = 0;
        }
        public override string ToString()
        {
            return $"Подорож до {JourneyCountry}";
        }
    }
}
