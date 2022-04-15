// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// System.Console.WriteLine(" Введите колличества числа: ");
// int Number = int.Parse(Console.ReadLine());
// int count = 0;
// for (int i = 0; i < Number; i++)
// {
//     Console.WriteLine(" Введите числа: ");
//     int number = int.Parse(Console.ReadLine());
//     if (number > 0)
//         count++;
// }
// System.Console.Write(" Колличество чисел больше нуля: " + count);

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
//            или задаются вручную.

// Console.WriteLine("Введите координаты точки b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты точки k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// if ( k1 == k2) Console.WriteLine(" Прямые параллельные ");
// else
// {
    
//     double x = (b2 - b1)/(k1 - k2);
//     double y = k1 * x + b1;
//     System.Console.WriteLine(" Координата х = " + x);
//     System.Console.WriteLine(" Координата у = " + y);
// }