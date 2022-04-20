
using MyThirdHomeWork;

ExcesizePhone phone = new ExcesizePhone();

Console.WriteLine($"Please write your phone size");
string sizetext = Console.ReadLine();
double size = double.Parse(sizetext);
phone.Size = size;
Console.WriteLine($"phone size is: {size}");


string brand = Console.ReadLine();
phone.Brand = brand;    

string model = Console.ReadLine();
phone.Model = model;



