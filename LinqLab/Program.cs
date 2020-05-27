using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {10, 2330, 112233, 10, 949, 3764, 2942};
            List<Student> students = new List<Student>()
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10),
            };
            Console.WriteLine(nums.Max(x=> x));
            Console.WriteLine(nums.Min(x=>x));
            Console.WriteLine(nums.Where(x => x < 10000).Max());
            
            nums.Where(x => x > 10
                            && x < 100)
                .ToList()
                .ForEach(Console.WriteLine);
            
            nums.Where(x => x >= 100000
                            && x <= 999999)
                .ToList()
                .ForEach(Console.WriteLine);
            Console.WriteLine(nums.Count(x=> x % 2 == 0));

            students.Where(x => x.Age >= 21).ToList().ForEach(PrintStudent);
            
            int oldest = students.Max(x => x.Age);
            int youngest = students.Min(x => x.Age);
            
            Console.WriteLine(students.FirstOrDefault(x=> x.Age == oldest)?.Name + ": " +oldest);
            Console.WriteLine(students.FirstOrDefault(x=> x.Age == youngest)?.Name + ": " +youngest);
            
            int oldestUnder25 = students.Where(x=> x.Age < 25).Max(x => x.Age);
            
            Console.WriteLine(students.FirstOrDefault(x=> x.Age == oldestUnder25)?.Name + ": " +oldestUnder25);

            students.Where(x =>
                    x.Age > 21 &&
                    x.Age % 2 == 0)
                .ToList()
                .ForEach(PrintStudent);
            
            students.Where(x =>
                    x.Age >= 13 &&
                    x.Age <= 19)
                .ToList()
                .ForEach(PrintStudent);
            
            students.Where(x =>
                    "aeiouAEIOU".Contains(x.Name[0]))
                .ToList()
                .ForEach(PrintStudent);
        }

        public static void PrintStudent(Student s)
        {
            Console.WriteLine($"Name: {s.Name}\n" +
                              $"Age: {s.Age}");
        }
    }
}