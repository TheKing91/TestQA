using System;

class Program
{
    static void Main(string[] args)
    {
        // Input coordinates of the three points
        Console.WriteLine("Enter the coordinates of point A (x,y):");
        string[] inputA = Console.ReadLine().Split(',');
        double xA = double.Parse(inputA[0]);
        double yA = double.Parse(inputA[1]);

        Console.WriteLine("Enter the coordinates of point B (x,y):");
        string[] inputB = Console.ReadLine().Split(',');
        double xB = double.Parse(inputB[0]);
        double yB = double.Parse(inputB[1]);

        Console.WriteLine("Enter the coordinates of point C (x,y):");
        string[] inputC = Console.ReadLine().Split(',');
        double xC = double.Parse(inputC[0]);
        double yC = double.Parse(inputC[1]);

        double AB = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
        double BC = Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2));
        double AC = Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2));

        Console.WriteLine($"Length of AB is: {AB}");
        Console.WriteLine($"Length of BC is: {BC}");
        Console.WriteLine($"Length of AC is: {AC}");

        bool isEquilateral = (AB == BC && BC == AC);
        bool isIsosceles = (AB == BC || BC == AC || AC == AB);
        bool isRightTriangle = (AB * AB + BC * BC == AC * AC ||
                                BC * BC + AC * AC == AB * AB ||
                                AC * AC + AB * AB == BC * BC);

        if (isEquilateral)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (isIsosceles)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is neither equilateral nor isosceles.");
        }

        if (isRightTriangle)
        {
            Console.WriteLine("The triangle is right-angled.");
        }
        else
        {
            Console.WriteLine("The triangle is not right-angled.");
        }

        
        double perimeter = AB + BC + AC;

        Console.WriteLine($"The perimeter of the triangle is: {perimeter}");

        Console.WriteLine("Even numbers from 0 to the perimeter:");
        for (int i = 0; i <= perimeter; i += 2)
        {
            Console.Write($"{i} ");
        }
    }
}