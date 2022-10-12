using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            FamilyMembers = new List<Person>();
        }
        public List<Person> FamilyMembers { get; set; }
        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }
        public Person GetOldestMember()
        {
            Person result =new Person();
            int maxVal=FamilyMembers.Max(x=>x.Age);
            result=FamilyMembers.Find(x=>x.Age>=maxVal);
            return result;
        }
    }
}
