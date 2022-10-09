// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 4|number < 1)
{
    Console.WriteLine("Такой четверти не существует!");
    Console.Write("Введите номер четверти: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number == 1) Console.WriteLine("x > 0, y > 0");
else if (number == 2) Console.WriteLine("x < 0, y > 0");
else if (number == 3) Console.WriteLine("x < 0, y < 0");
else if (number == 4) Console.WriteLine("x > 0, y < 0");

// bool one = true;
// while (one)
// {
// try
// {
// Console.WriteLine("Введите номер четверти");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0 && num <= 4)
// {
// if (num == 1)
// {
// Console.WriteLine("x > 0 и y > 0");
// }
// if (num == 2)
// {
// Console.WriteLine("x < 0 и y > 0");
// }
// if (num == 3)
// {
// Console.WriteLine("x < 0 и y < 0");
// }
// if (num == 4)
// {
// Console.WriteLine("x > 0 и y < 0");
// }
// one = false;
// } else Console.WriteLine("Вы не попали в диапазон чисел от 1 до 4");
// }
// catch
// {
// Console.WriteLine("Ошибка ввода, попробуйте еще раз: ");
// }
// }