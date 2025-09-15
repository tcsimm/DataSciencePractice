using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

public record Person(string Name, int Age);

class Program
{
    static void Main()
    {
        //variables and types
        int x = 42;
        string who = "Thomas";
        double pi = 3.1415;
        bool ok = true;
        DateTime now = DateTime.UtcNow;

        Console.WriteLine($"hi {who}, x={x}, pi≈{pi:F2}, ok={ok}, now={now:O}");

        //arrays and lists
        int[] a = {1,2,3,4,6};
        var list = new List<int> {3, 6, 9};

        // LINQ
        var evens = a.Where(n => n % 2 == 0).Select(n=>n*n);
        Console.WriteLine(string.Join(", ", evens)); 

        // records
        var p = new Person("Ada", 36);
        var older = p with { Age = p.Age + 1};
        Console.WriteLine(older);

        // dictionaries
        var counts = new Dictionary<string,int> {["a"]=2, ["b"]=3};
    }
}