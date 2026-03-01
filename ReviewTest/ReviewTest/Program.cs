// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nrOfPrints = 10;
var run = true;

while(run)
{
    Console.WriteLine("Row number = " + nrOfPrints);

    nrOfPrints++;

    run = nrOfPrints == 0;
}