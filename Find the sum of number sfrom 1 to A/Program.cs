// Найти сумму чисел от 1 до А

// Console.WriteLine("Enter number: ");
// int A = int.Parse(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= A; i++){

//     sum = sum + i;
//     Console.WriteLine("i = " );
//     Console.WriteLine("Sum" + i + "=" + sum);
// }

// Console.WriteLine("Sum = "+ sum );

// Найти сумму чисел от 1 до А вторая версия
 
 Console.WriteLine("Введите число : " ?? "0");
int A = int.Parse(Console.ReadLine());
int counter =1;
int sum = 0;

while (counter <= A)
{
    sum = sum + counter; 
    counter ++;
}

Console.WriteLine("Сумма чисел от 1 " + "до А равна: " + sum);
