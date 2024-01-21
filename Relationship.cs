using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Creating_Classes
{
    internal class Relationship
    {
        
        public string RelationshipType { get; set; }
        public string Person1 { get; set; }
        public string Person2 { get; set; } 

        
        public Relationship(string person1, string person2, string relationshipType)
        {
            RelationshipType = relationshipType;
            Person1 = person1;
            Person2 = person2;
        }

        public void ShowRelationship()
        {
            Console.WriteLine($"Relationship between {Person1} and {Person2} is: {RelationshipType}");
        }




    }
}
