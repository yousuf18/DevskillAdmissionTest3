// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, World!");
PrimeFinder primeFinder = new PrimeFinder();
var actualResult = primeFinder.GetPrimes(10000, 20000);
foreach(var result in actualResult)
    Console.Write($"{result}, ");