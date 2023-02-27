namespace _04._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> register =
                new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArg[0];
                string username = cmdArg[1];

                if (cmdType=="register")
                {
                    string licensePlateNumber = cmdArg[2];
                    if (!register.ContainsKey(username))
                    {
                        register[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        string registeredPlateNumber = register[username];
                        Console.WriteLine($"ERROR: already registered with plate number {registeredPlateNumber}");
                    }
                }
                else if (cmdType=="unregister")
                {
                    if (!register.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        register.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var ulpnp in register)
            {
                Console.WriteLine($"{ulpnp.Key} => {ulpnp.Value}");
            }
        }
    }
}