using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSONParse
{
    public class Program
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }
        }
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<Student>();

            while (input.IndexOf("name") != -1)
            {
                var student = new Student();

                var firstIndexOfName = input.IndexOf("name") + 6;
                input = input.Remove(0, firstIndexOfName);

                student.Name = input.Substring(0, input.IndexOf('\"'));
                student.Grades = new List<int>();
                input = input.Remove(0, student.Name.Length + 2);

                var firstIndexOfAge = input.IndexOf("age") + 4;
                input = input.Remove(0, firstIndexOfAge);
                student.Age = int.Parse(input.Substring(0, input.IndexOf(',')));
                input = input.Remove(0, student.Age.ToString().Length);

                var firstIndexOfGrades = input.IndexOf("grades:") + 8;
                input = input.Remove(0, firstIndexOfGrades);

                var stringOfGrades = input.Substring(0, input.IndexOf(']'));
                var grades = stringOfGrades.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                student.Grades.AddRange(grades);

                students.Add(student);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} : {student.Age} -> {(student.Grades.Count>0 ? string.Join(", ",student.Grades):"None")}");
            }
           
        }
    }
}
