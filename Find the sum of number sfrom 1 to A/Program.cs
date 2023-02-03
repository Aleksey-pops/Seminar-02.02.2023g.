// Найти сумму чисел от 1 до А

Console.WriteLine("Enter number: ");
int A = int.Parse(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= A; i++){

    sum = sum + i;
    Console.WriteLine("i = " );
    Console.WriteLine("Sum" + i + "=" + sum);
}

Console.WriteLine("Sum = "+ sum );