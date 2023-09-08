// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8

// Console.Write("Введи трёхзначное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string stNumb = Convert.ToString(Number);
// Console.WriteLine(stNumb[1]);



// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string stNumb = Convert.ToString(Number);

// if(stNumb.Length > 2) 
// {
    // Console.WriteLine(stNumb[2]);
// }
// else
// {
    // Console.WriteLine("No");
// }



// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if(1 <= Number && Number <= 5)
{
    Console.WriteLine("No");
}
else if(Number == 6 || Number == 7)
{
    Console.WriteLine("Yes");
}
else if(Number < 0 || Number > 7)
{
    Console.WriteLine("Решения не имеет");
}
