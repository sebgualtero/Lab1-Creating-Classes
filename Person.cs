using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes
{
    internal class Person
    {
        // Properties

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string FavoriteColor { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }




        // Constructor
        public Person(int personID, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            PersonId = personID;
            FirstName = firstName;
            LastName = lastName;
            FavoriteColor = favoriteColor;
            Age = age;
            IsWorking = isWorking;
        }

        // Methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"{PersonId}: {FullName}'s favorite color is {FavoriteColor}");
        }

        public void ChangeFavoriteColor()
        {
            FavoriteColor = "White";
        }

        public void GetAgeInTenYears()
        {
            Console.WriteLine($"{FullName}'s age in 10 years is: {Age + 10}");
        }

        public void ToString()
        {
            Console.WriteLine($"PersonID: {PersonId}" +
                $"\nFirstName:{FirstName}" +
                $"\nLastName: {LastName}" +
                $"\nFavoriteColor: {FavoriteColor}" +
                $"\nAge: {Age}" +
                $"\nIsWorking: {IsWorking}");
        }
    }
}
