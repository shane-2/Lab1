using System.ComponentModel.Design;

Console.WriteLine("Welcome! Please enter a width of your room.");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the Length of your room.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter a height of your room.");
double height =  double.Parse(Console.ReadLine());

double perimeter = (width * 2) + (length * 2);
double area = length * width;
double volume = area * height;

double a = (area * 2);
double b = (width * height * 2);
double c = (length * height * 2);
double surfArea = a + b + c;

Console.WriteLine("The area of the room is " + area + ". The perimeter of the room is " + perimeter + ". The surface area of the room is " + surfArea + ". The volume of the room is " + volume + ".");

if (area <= 250)
{
    Console.WriteLine("The room is small.");
}
else if (area < 650 && area > 250)
{
    Console.WriteLine("The room is medium.");
}
else if (area >= 650)
    Console.WriteLine("The room is large.");