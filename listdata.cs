using System;
using System.Collections.Generic;

public class student
{
    public int id { get; set; }
    public string username { get; set; }
    public string password { get; set; }
}

public class entrypoint
{
    public static void Main(string[] args)
    {
        List<student> list = new List<student>()
        {
            new student { id = 1, username = "alok", password = "pass123" },
            new student { id = 2, username = "rahul", password = "secure456" },
            new student { id = 3, username = "neha", password = "hello789" }
        };

        // Display the data
        foreach (var s in list)
        {
            Console.WriteLine($"ID: {s.id}, Username: {s.username}, Password: {s.password}");
        }
    }
}