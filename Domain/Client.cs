using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3.Domain
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public Car Car { get; set; }
        public Property Property { get; set; }
        public Journeys Journeys { get; set; }
        public decimal InsCasco { get; set; }
        public decimal InsOscpv { get; set; }
        public decimal InsDcv { get; set; }
        public decimal InsProperty { get; set; }
        public decimal InsTravel { get; set; }
        public decimal InsTotal { get; set; }
        public decimal TotalSum { get; set; }

        public Client(string firstName, string lastName, string middleName, string phone, string age, string city, Car car, Property property, Journeys journeys, decimal insCasco, decimal insOscpv, decimal insDcv, decimal insProperty, decimal insTravel, decimal insTotal, decimal totalSum)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phone;
            Age = age;
            City = city;
            Car = car;
            Property = property;
            Journeys = journeys;
            InsCasco = insCasco;
            InsOscpv = insOscpv;
            InsDcv = insDcv;
            InsProperty = insProperty;
            InsTravel = insTravel;
            InsTotal = insTotal;
            TotalSum = totalSum;
        }
        
        public Client()
        {
            FirstName = "";
            LastName = "";
            MiddleName = "";
            PhoneNumber = "";
            Age = "";
            City = "";
            Car = new Car();
            Property = new Property();
            Journeys = new Journeys();
            InsCasco = 0;
            InsOscpv = 0;
            InsDcv = 0;
            InsProperty = 0;
            InsTravel = 0;
            InsTotal = 0;
            TotalSum = 0;
        }

        public override string ToString()
        {
            return $"Клієнт {LastName} {FirstName} {MiddleName}\n" +
                $"Вік {Age} Місто {City} Контактний телефон: {PhoneNumber}\n" +
                $"Автомобіль {Car} \n " +
                $"Страховка КАСКО {InsCasco}" +
                $"Страховка ОСЦПВ {InsOscpv}" +
                $"Страховка ДЦВ {InsDcv}" +
                $"Майно {Property}, Страховка {InsProperty}\n" +
                $"Подорож {Journeys}, {InsTravel}\n" +
                $"Загальна сума {TotalSum}";
        }
    }
}
