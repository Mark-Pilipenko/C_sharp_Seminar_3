Console.Write("Enter x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("Point is in 1-st quarter.");
else if (x < 0 && y > 0) Console.WriteLine("Point is in 2-nd quarter.");
else if (x < 0 && y < 0) Console.WriteLine("Point is in 3-d quarter.");
else if (x > 0 && y < 0) Console.WriteLine("Point is in 4-th quarter.");