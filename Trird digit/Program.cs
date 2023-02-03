// Определить 3 цифру по порядку чему она равна

Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
while (number >= 1000)
{
    number = number / 10;
}
// int number = int.Parse(Console.)
Console.WriteLine("Trird digit: " + (number % 10));
