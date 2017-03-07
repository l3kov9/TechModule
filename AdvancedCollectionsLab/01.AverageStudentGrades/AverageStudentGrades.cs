namespace _01.AverageStudentGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AverageStudentGrades
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var studentsGrade = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var name = input[0];
                var grade = double.Parse(input[1]);
                AddGrade(studentsGrade, name, grade);
            }

            foreach (var kvp in studentsGrade)
            {
                var name = kvp.Key;
                var grades = kvp.Value;
                Console.WriteLine($"{name} -> {string.Join(" ",grades.Select(a=>string.Format("{0:f2}",a)))} (avg: {grades.Average():f2})");
            }
        }

        private static void AddGrade(Dictionary<string, List<double>> studentsGrade, string name, double grade)
        {
            if (!studentsGrade.ContainsKey(name))
            {
                studentsGrade[name] = new List<double>();
            }
            studentsGrade[name].Add(grade);
        }
    }
}
