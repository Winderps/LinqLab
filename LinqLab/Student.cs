using System;
using System.Collections.Generic;
using System.Text;
namespace LinqLab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}