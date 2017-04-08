namespace _02.Stateless
{
    using System;
    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();

            while (!state.Equals("collapse"))
            {
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    if (state.Contains(fiction))
                    {
                        state = state.Replace(fiction, string.Empty);
                    }

                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0)
                    {
                        fiction = fiction.Remove(fiction.Length - 1);
                    }
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state.Trim());
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                state = Console.ReadLine();
            }

        }
    }
}
