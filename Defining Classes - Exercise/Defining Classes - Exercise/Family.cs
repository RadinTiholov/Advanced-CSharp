using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.FamilyProp = new List<Person>();
        }
        public List<Person> FamilyProp { get; set; }
        public void AddMember(Person member) 
        {
            FamilyProp.Add(member);
        }
        public Person GetOldestMember() 
        {
            int maxAge = int.MinValue;
            Person personToReturn = new Person();
            foreach (var person in FamilyProp)
            {
                if (person.Age > maxAge)
                {
                    maxAge = person.Age;
                    personToReturn = person;
                }
            }
            return personToReturn;
        }
    }
}
