// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nrOfPrints = 10;
var run = true;

while(run)
{

    nrOfPrints++;

    run = nrOfPrints == 0;

    Console.WriteLine("Row number = " + nrOfPrints);

}