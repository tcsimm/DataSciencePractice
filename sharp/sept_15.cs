using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        //variables and types
        int x = 42;
        string who = "Thomas";
        double pi = 3.1415;
        bool ok = True;
        DateTime now = DateTime.UtcNow;

        Console.WriteLine($"hi {who}, x={x}, pi≈{pi:F2}, ok={ok}, now={now:O}");
    }
}