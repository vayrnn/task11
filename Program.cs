using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        var result = UtilityClass.SomeUtilityMethod("Hello, NuGet!"); 
        Console.WriteLine($"Результат работы метода: {result}");
    }
}
