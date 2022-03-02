// See https://aka.ms/new-console-template for more information
using PearlNecklace;

//Create a couple of Random pearls
Console.WriteLine("Create a couple of Random pearls");
Console.WriteLine(Pearl.Factory.CreateRandomPearl());
Console.WriteLine(Pearl.Factory.CreateRandomPearl());

//Create a random Necklaces
Console.WriteLine("\nCreate a random Necklaces");
var necklace = Necklace.Factory.CreateRandomNecklace(35);
Console.WriteLine(necklace);
Console.WriteLine($"Nr of pearls: {necklace.Count()}");
Console.WriteLine($"Nr of Freshwater pearls: {necklace.Count(PearlType.FreshWater)}");
Console.WriteLine($"Nr of Saltwater pearls: {necklace.Count(PearlType.SaltWater)}");
Console.WriteLine($"Price of the necklace: {necklace.Price}");

//Sort the Necklace
Console.WriteLine("\nSort the Necklace");
necklace.Sort();
Console.WriteLine(necklace);

//Find a pearl, test by using a kown pearl
Console.WriteLine("\nFind a pearl, test by using a kown pearl");
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


//Reference vs Value Pearl
Console.WriteLine("\nReference vs Value Pearl");
var p1 = Pearl.Factory.CreateRandomPearl();
var p2 = Pearl.Factory.CreateRandomPearl();
Console.WriteLine("Original pearls");
Console.WriteLine($"p1: {p1}");
Console.WriteLine($"p2: {p2}");
p1 = p2;
p1.Color = PearlColor.White;
p1.Type = PearlType.SaltWater;
p1.Shape = PearlShape.DropShaped;
Console.WriteLine("\nAfter p1 = p2 assignment and change p2");
Console.WriteLine($"p1: {p1}");
Console.WriteLine($"p2: {p2}"); 



