using System;
using System.Collections.Generic;
using System.Linq;
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
        public int Age { get; set; }
        public string City { get; set; }
        public Car Car { get; set; }
        public Property Property { get; set; }
        public Journeys Journeys { get; set; }

        public Client(string firstName, string lastName, string middleName, string phone, int age, string city, Car car, Property property, Journeys journeys)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            PhoneNumber = phone;
            Age = age;
            City = city;
            Car = new Car();
            Property = new Property();
            Journeys = new Journeys();  
        }
        public Client()
        {
            FirstName = "";
            LastName = "";
            MiddleName = "";
            PhoneNumber = "";
            Age = 0;
            City = "";
            Car = new Car();
            Property = new Property();
            Journeys = new Journeys();
        }

        public override string ToString()
        {
            return $"Клієнт {LastName} {FirstName} {MiddleName}";
        }
    }
}
