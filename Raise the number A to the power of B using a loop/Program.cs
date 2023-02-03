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

// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Enter 1st number: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2nd number: ");
int B = int.Parse(Console.ReadLine());

int sum = A;
if(B == 0)
{
    Console.WriteLine("Sum = 1");
}
else
{
    for(int i = 1; i < B; i++)
    {

        sum = sum * A;
    }
    Console.WriteLine($"Sum = {sum}");
}