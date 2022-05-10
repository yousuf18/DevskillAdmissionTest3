// See https://aka.ms/new-console-template for more information
using Task3;
Console.WriteLine("Input Lower Value");
int lowervalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Upper Value");
int Uppervalue = Convert.ToInt32(Console.ReadLine());
PrimeFinder primeFinder = new PrimeFinder();
var actualResult = primeFinder.GetPrimes(lowervalue, Uppervalue);
foreach (var result in actualResult)
{
    if (result == 0)
        return;
    Console.Write($"{result}, ");
}