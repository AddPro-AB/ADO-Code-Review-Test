// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nrOfPrints = 0;
var run = true;

while (run)
{

    nrOfPrints++;

    Console.WriteLine("Row number = " + nrOfPrints);

    run = nrOfPrints <= 10;

}