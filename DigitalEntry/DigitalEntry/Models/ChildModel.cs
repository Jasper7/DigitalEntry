using System;
using System.Collections.Generic;

namespace DigitalEntry.Models
{
    public class ChildModel
    {
        public ChildModel(int id, string firstName, string lastName, byte age, string schoolName, string className)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ClassName = className;
            SchoolName = schoolName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public string Description { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }

        public List<ParentModel> Parents { get; set; }
    }
}