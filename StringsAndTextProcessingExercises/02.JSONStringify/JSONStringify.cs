namespace _02.JSONStringify
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class JSONStringify
    {
        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<int> Grades { get; set; }

            public static void Main()
            {
                var students = new List<Student>();

                var input = Console.ReadLine();

                while (!input.Equals("stringify"))
                {
                    var student = new Student();

                    var inputLine = input.Split(':');
                    student.Name = inputLine[0].Trim();
                    var ageAndGrades = inputLine[1].Split(new[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    student.Age = int.Parse(ageAndGrades[0]);
                    ageAndGrades.RemoveAt(0);
                    student.Grades = new List<int>();
                    foreach (var grade in ageAndGrades)
                    {
                        student.Grades.Add(int.Parse(grade));
                    }

                    students.Add(student);

                    input = Console.ReadLine();
                }
                var output = new List<string>();

                foreach (var student in students)
                {
                    output.Add($"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ",student.Grades)}]}}");
                }

                Console.WriteLine("["+string.Join(",",output)+"]");
            }
        }
    }
}
