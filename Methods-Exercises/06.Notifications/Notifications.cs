namespace _06.Notifications
{
    using System;
    public class Notifications
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();
                while (result != "success" && result != "error")
                {
                    result = Console.ReadLine();
                }

                if (result.Equals("success"))
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    ShowSuccess(operation, message);
                }
                else if (result.Equals("error"))
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    ShowError(operation, code);
                }
            }
        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($@"Successfully executed {operation}.
==============================
Message: {message}."
);
        }

        static void ShowError(string operation, int code)
        {
            var reason=string.Empty;
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }
            Console.WriteLine($@"Error: Failed to execute {operation}.
==============================
Error Code: {code}.
Reason: {reason}.");
        }
    }
}
