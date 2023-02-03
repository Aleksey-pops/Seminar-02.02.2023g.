using System;
// // Сколько цифр в числе (разрядов)

// Console.WriteLine("Введите первое число: " ?? "0");
// int A = int.Parse(Console.ReadLine());

// int count = 1;
// int res = Math.Abs(A);
// while (res > 1)
// {
//     res = res / 10;
//     count ++;    
// }
// Console .WriteLine("Количество цифр в числе: "+ count);



// // // Сколько цифр в числе (разрядов) Вариант 2

// // Console.WriteLine("Введите первое число: " ?? "0");
// // int A = int.Parse(Console.ReadLine());
// // int count = 1;

// // for (int res = Math.Abs(A); (res > 1); res = res /10, count++);
// // {
// //    Console .WriteLine("Количество цифр в числе: "+ count); 
// }

//  С doble больше чисел считает!!!

Console.WriteLine("Введите первое число: " ?? "0");
int A = int.Parse(Console.ReadLine());

int counter = 0;
if (A == 1)
{
    counter ++;
    Console.WriteLine($"couter = {counter}");
}
else
{
    while (A!= 0)
    {
        counter++;
        A = A / 10;
    }
    Console.WriteLine($"counter = {counter}");
}