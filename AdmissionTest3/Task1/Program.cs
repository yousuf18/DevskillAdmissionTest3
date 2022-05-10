// See https://aka.ms/new-console-template for more information


using Task1;

var text = Console.ReadLine();

VowelCounter vowelCounter = new VowelCounter();
if (string.IsNullOrEmpty(text))
    return;
var result = vowelCounter.GetCounts(text);

result = result.Substring(0, result.Length - 1);
Console.WriteLine(result);
