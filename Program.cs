// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// ------------------------------------------------------
// System.Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a>b)
// {
//     Console.WriteLine(a);  
// }
// else
// {
//     Console.WriteLine(b);
// }
// if (a == b)
// {
//     Console.WriteLine("Выражения равны");
// }
// ------------------------------------------------


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// -----------------------------------------------------

// using System.ComponentModel.DataAnnotations;

// System.Console.WriteLine("Введите первое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = 0;

// if (a>b)
// {
//     max = b;
// }
// else
// {
//     max = a;
// }

// if ( max > c)
// {
//     Console.WriteLine(max);
// }
// else
// {
//     Console.WriteLine(c);
// }

// -----------------------------------------

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// ----------------------------------------------

// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// if (a%2 == 0)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// ------------------------------------------------


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// -------------------------------------------------


// System.Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = 0;
// while (b<a)
// {
//     b = b +2;
//     if (b>a)
//     {
//         break;
//     }
//     Console.WriteLine(b);
// }