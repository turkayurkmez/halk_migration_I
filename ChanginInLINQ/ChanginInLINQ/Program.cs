// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var collection = Enumerable.Range(1, 10);
collection.ToList().ForEach(x => Console.WriteLine(x));
var number = collection.ElementAt(^2);
Console.WriteLine(number);
Console.WriteLine("======= Take ======");

//collection.Skip(0).Take(3).ToList().ForEach(x => Console.WriteLine(x));
//collection.SkipLast(0).TakeLast(3).ToList().ForEach(x => Console.WriteLine(x));
collection.Take(6..19).ToList().ForEach(x => Console.WriteLine(x));
collection.Take(^2..).ToList().ForEach(x => Console.WriteLine(x));
collection.Take(..^2).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine("Sondan başa ");
collection.Take(^6..^2).ToList().ForEach(x => Console.WriteLine(x));

Console.WriteLine("==== DistinctBy ====");
Console.WriteLine("Mod 3 listesi:");
collection.Select(x => x % 3).ToList().ForEach(x => Console.WriteLine(x));
Console.WriteLine(".......... Distinct By -----");
var modulosByThree = collection.DistinctBy(x => x % 3);
modulosByThree.ToList().ForEach(x => Console.WriteLine(x));

//By ile biten Extension metotlar, belirli bir özellik üzerinden eşitliğin belirtilmesini sağlar...

var products = new (string name, double price)[]
{
    ("Ürün A",20),
    ("Ürün B",25),
    ("Ürün C",40),
    ("Ürün D",40),



};

Console.WriteLine("....... MaxBy.........");
var maxPrice = products.MaxBy(p => p.price);
Console.WriteLine(maxPrice.name);

var max = products.Max(p => p.price);

var chunks = collection.Chunk(size: 3);
Console.WriteLine("test");

Console.WriteLine("==== Artık Default value girebiliyoruz =======");
var firstItemOnDefault = collection.FirstOrDefault(x => x > 10, -1);
Console.WriteLine(firstItemOnDefault);



