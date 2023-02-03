// // Возведите число А в натуральную степень B используя цикл

// Console.WriteLine("Enter 1st number: ");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Enter 2nd number: ");
// int B = int.Parse(Console.ReadLine());

// int sum = A;
// if
// for(int i = 1; i < B; i++){

//     sum = sum * A;
// }
// Console.WriteLine($"Sum = {sum}");
// // A^B

// // Возведите число А в натуральную степень B используя цикл

// // Console.WriteLine("Enter 1st number: " ?? "0");
// // int A = int.Parse(Console.ReadLine());

// // Console.WriteLine("Enter 2nd number: ");
// // int B = int.Parse(Console.ReadLine());

// // int sum = A;
// // if(B == 0)
// // {
// //     Console.WriteLine("Sum = 1");
// // }
// // else
// // {
// //     for(int i = 1; i < B; i++)
// //     {

// //         sum = sum * A;
// //     }
// //     Console.WriteLine($"Sum = {sum}");
// }
// ??? Почему то при возведении в степень 12 и больше появляется число с минусом???

Console.WriteLine("Введите число : " ?? "0");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень числа : ");
int step = int.Parse(Console.ReadLine());

int res = 1;

if (step >= 0)
{
    for (int i = 0; i < step; i++) {
    res = number * res;
    }
    Console.WriteLine("Результат: " + res);
}
else
{
    Console.WriteLine("Требуется положительная степень!");
}