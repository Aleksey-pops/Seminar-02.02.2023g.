// // Сколько цифр в числе (разрядов)

// Console.WriteLine("Введите первое число: " ?? "0");
// int number = int.Parse(Console.ReadLine());

// int count = 1;
// int res = Math.Abs(number);
// while (res > 1)
// {
//     res = res / 10;
//     count ++;    
// }
// Console .WriteLine("Количество цифр в числе: "+ count);

// Сколько цифр в числе (разрядов) Вариант 2

Console.WriteLine("Введите первое число: " ?? "0");
int number = int.Parse(Console.ReadLine());
int count = 1;

for (int res = Math.Abs(number); (res > 1); res = res /10, count++);
{
   Console .WriteLine("Количество цифр в числе: "+ count); 
}
//  С doble больше чисел считает!!!