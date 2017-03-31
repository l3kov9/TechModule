namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Animals
    {
        public static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            var input = Console.ReadLine();

            while (!input.Equals("I'm your Huckleberry"))
            {
                var list = input.Split().ToList();

                var className = list[0];
                var name = list[1];
                if (className.Equals("talk"))
                {
                    var nameToTalk = list[1];
                    if (dogs.ContainsKey(nameToTalk))
                    {
                        dogs[nameToTalk].ProduceSound();
                    }
                    else if (cats.ContainsKey(nameToTalk))
                    {
                        Cat.ProduceSound();
                    }
                    else if (snakes.ContainsKey(nameToTalk))
                    {
                        Snake.ProduceSound();
                    }
                }
                else
                {
                    var age = int.Parse(list[2]);
                    var parameter = int.Parse(list[3]);

                    if (className.Equals("Dog"))
                    {
                        var dog = new Dog
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter
                        };

                        dogs[name] = dog;
                    }
                    else if (className.Equals("Cat"))
                    {
                        var cat = new Cat
                        {
                            Name = name,
                            Age = age,
                            IntelligenceQuontient = parameter
                        };

                        cats[name] = cat;
                    }
                    else if (className.Equals("Snake"))
                    {
                        var snake = new Snake
                        {
                            Name = name,
                            Age = age,
                            CrueltyCoefficient = parameter
                        };

                        snakes[name] = snake;
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var dog in dogs.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuontient}");
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }

        public class Dog
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NumberOfLegs { get; set; }

            public void ProduceSound()
            {
                Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
            }
        }

        public class Cat
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int IntelligenceQuontient { get; set; }
            public static void ProduceSound()
            {
                Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
            }
        }

        public class Snake
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int CrueltyCoefficient { get; set; }
            public static void ProduceSound()
            {
                Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
            }
        }
    }

}