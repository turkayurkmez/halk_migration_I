
// See https://aka.ms/new-console-template for more information
using NewInCSharp;
using NewInCSharp.Models;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

var parse = (string value) => int.Parse(value);

var parseExpression = (string value) => int.Parse(value);

//Expression<Func<string,int>> expression = new Expression<Func<string, int>>()
var isEven = object (int number) => number % 2 == 0 ? 1 : "Tek sayıdır";

Person person = new Person();
//List<string> comments = new List<string>();
var comments = new string[2];
Product product = new Product("Gözlük", 750, comments);
Product product1 = new Product("Gözlük", 750, comments);

Console.WriteLine(product == product1);
Console.WriteLine(ReferenceEquals(product, product1));
product1.comments[1] = "Güzelmiş";

product.comments.ToList().ForEach(c => Console.WriteLine($"Bu product: {c}"));
product1.comments.ToList().ForEach(c => Console.WriteLine($"Bu product1: {c}"));


Console.WriteLine(product == product1);
Console.WriteLine(ReferenceEquals(product, product1));



var (city, street, postalCode) = getAddress();
Address address1 = new Address();
(address1.City, address1.Street, address1.PostalCode) = getAddress();

Console.WriteLine(address1.Street);

Address address = new Address { City = city, PostalCode = postalCode, Street = street };

Console.WriteLine($"{city} {street} {postalCode}");

var tupleResponse = getAddressTuple();


if (product == product1)
{
    Console.WriteLine("Evet eşit");
}
else
{
    Console.WriteLine("Hayır eşit değildir");
}
/*
 * Record'un farkları
 *   1. Sabit özellikler olacaksa, direkt varsayılan cons. ve parametre biçiminde kullanabilirsiniz.
 *       Örnek:  public record Product(string name, double price);
 *   2. Equals fonksiyonunu kullanarak, recordlar karşılaştırılabilir.
 *   3. Seçili özelliklerde değerleri sabit bir nesnenin kopyasını oluşturmak için with kullanılabilir.
 *   4. Record, record'dan miras alır ama class'dan alamaz. 
 */



(string, string, int) getAddress()
{
    var address = new Address();
    address.Street = "Alanönü";
    return (address.City, address.Street, address.PostalCode);
}

Tuple<string, string, int> getAddressTuple()
{
    var tuple = Tuple.Create<string, string, int>("Eskişehir", "Sümer", 26140);
    return tuple;
}

Tuple<int, int> divideTwoNumbers(int a, int b)
{
    var tuple = Tuple.Create<int, int>(a / b, a % b);
    return tuple;
}