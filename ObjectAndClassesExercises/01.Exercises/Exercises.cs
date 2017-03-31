namespace _01.Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Exercises
    {
        public static void Main()
        {
            var entry = Console.ReadLine();
            var listOfExercises = new List<Exercise>();

            while (!entry.Equals("go go go"))
            {
                var input = entry.Split(new[] { ' ', '>', '-', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var exercise = new Exercise
                {
                    Topic = input[0],
                    CourseName = input[1],
                    JudgeContestLink = input[2],
                    Problems = new List<string>(input.Skip(3))
                };

                listOfExercises.Add(exercise);

                entry = Console.ReadLine();
            }

            foreach (var exercise in listOfExercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}\nProblems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.\nCheck your solutions here: {exercise.JudgeContestLink}");

                var counter = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine(counter + ". " + problem);
                    counter++;
                }
            }

        }

        public class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public List<string> Problems { get; set; }
        }
    }
}
