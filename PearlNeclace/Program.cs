// See https://aka.ms/new-console-template for more information
using PearlNecklace;

//Create a couple of Random pearls
Console.WriteLine(Pearl.Factory.CreateRandomPearl());
Console.WriteLine(Pearl.Factory.CreateRandomPearl());
Console.WriteLine();

//Create a couple of Necklaces
var necklace = Necklace.Factory.CreateRandomNecklace(35);
Console.WriteLine(necklace);
Console.WriteLine($"Nr of pearls: {necklace.Count()}");
Console.WriteLine($"Nr of Freshwater pearls: {necklace.Count(PearlType.FreshWater)}");
Console.WriteLine($"Nr of Saltwater pearls: {necklace.Count(PearlType.SaltWater)}");
Console.WriteLine($"Price of the necklace: {necklace.Price}");
Console.WriteLine();

//Print the sorted Necklace
necklace.Sort();
Console.WriteLine(necklace);
Console.WriteLine();

//Find a pearl, test by using a kown pearl
var findPearl = necklace[23];

Console.WriteLine($"Looking for Pearl:\n{findPearl}");
int idx = necklace.IndexOf(findPearl);

if (idx == -1)
{
    Console.WriteLine("Could not find the pearl");
}
else
{
    Console.WriteLine($"Pearl found in position {idx}");
}


