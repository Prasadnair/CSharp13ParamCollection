// See https://aka.ms/new-console-template for more information
using ParamsInCSharp13;

Console.WriteLine("Params with Array!");
WithArray.Display(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);


Console.WriteLine("\nParams with Span");
WithSpan.Display(1, 2, 3, 4, 5);

Console.WriteLine("\nParams with List");

WithList.Display([1, 2, 3, 4, 5, 6, 7]);


Console.WriteLine("\nPress any key to exit");
Console.ReadKey();


