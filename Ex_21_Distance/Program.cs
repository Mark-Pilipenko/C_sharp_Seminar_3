// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

bool one = true;
while (one)
{
    try
    {
        Console.Write("Введите x точки А: ");
        double xa = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y точки А: ");
        double ya = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите x точки B: ");
        double xb = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите y точки B: ");
        double yb = Convert.ToDouble(Console.ReadLine());
        double dist = Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
        dist = Math.Round(dist, 2);
        Console.WriteLine("Расстояние между точками: " + dist);
        one = false;
    }
    catch
    {
        Console.WriteLine("Ошибка ввода!");
    }
}