namespace Lab1_Creating_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            gina.DisplayPersonInfo();
            mike.ToString();

            ian.ChangeFavoriteColor();
            ian.DisplayPersonInfo();
            mary.GetAgeInTenYears();

            Relationship relationship1 = new Relationship("gina", "mary", "Sisterhood");
            Relationship relationship2 = new Relationship("ian", "mike", "Brotherhood");

            relationship1.ShowRelationship();
            relationship2.ShowRelationship();

            
            List<Person> people = new List<Person>();
            people.Add(ian);
            people.Add(gina);
            people.Add(mike);
            people.Add(mary);

            Console.WriteLine("People in the list: " + people.Count);

            
            decimal totalAge = 0;
            foreach (Person person in people)
            {
                totalAge += person.Age;
            }

            decimal AverageAge = totalAge / people.Count;
            
            Console.WriteLine($"Average age of people in the list: {AverageAge}");

            
            int youngestAge = people[0].Age;
            string youngestName = people[0].FullName;   
            foreach (Person person in people)
            {
                if (person.Age < youngestAge)
                {
                    youngestAge = person.Age;
                    youngestName = person.FullName;
                }
            }
            Console.WriteLine($"The Youngest person is: {youngestName}");

            
            int oldestAge = people[0].Age;
            string oldestName = people[0].FullName;

            foreach (Person person in people)
            {
                if (person.Age > oldestAge)
                {
                    oldestAge = person.Age;
                    oldestName = person.FullName;
                }
            }
            Console.WriteLine($"The Oldest person is: {oldestName}");

            
            foreach (Person person in people)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    person.ToString();
                }
            }

            foreach (Person person in people)
            {
                if (person.FavoriteColor == "Blue")
                {
                    person.ToString();
                }
            }


        }
    }
}
