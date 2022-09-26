

string restart = "Y";
while (restart == "Y")
{
    Console.WriteLine("Please input the radius of a circle");

    string input = Console.ReadLine();
    double radius = double.Parse(input);

    Console.WriteLine("Radius: " + radius);

    double area = Math.PI * radius * radius;

    Console.WriteLine("Area: " + area);

    Console.WriteLine("Would you like to measure another circle? Y/N");

    restart = Console.ReadLine();
}

Console.WriteLine("Goodbye!");










