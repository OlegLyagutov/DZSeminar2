// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine($"Введите трёхзначное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// int firstDigit = Number / 10;
// int secondDigit = firstDigit % 10;
// Console.WriteLine($"Вторая цифра: {secondDigit} ");

// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string IndexNumber = Convert.ToString(number);
// if (IndexNumber.Length > 2)
// {
//     Console.WriteLine($"Третья цифра " + IndexNumber[2]);
// }
// else
// {
//     Console.WriteLine("Такой цифры нет");
// }



// Задача 15: Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите число дня недели: ");
// int DayNumber = Convert.ToInt32(Console.ReadLine());
// if (DayNumber < 6)
// {
//     Console.WriteLine("Нет, не выходной. ");
// }
// else
// {
//     Console.WriteLine("Да, выходной. ");
// }