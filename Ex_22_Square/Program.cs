// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

bool one = true;
while (one)
{
    try
    {
        Console.Write("Введите натуральное число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        if (N > 0)
        {
            Console.Write("Квадраты чисел от 1 до N: ");
            for (int i = 1; i <= N; i++)
            {
                if (i == N) Console.Write(Math.Pow(i, 2) + ".");
                else Console.Write(Math.Pow(i, 2) + ", ");
            }
            one = false;
        }
        else Console.WriteLine("Число не натуральное!");
    }
    catch
    {
        Console.WriteLine("Ошибка ввода!");
    }
}