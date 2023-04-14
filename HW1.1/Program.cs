System.Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    System.Console.WriteLine($"Число {number1} max ");
}
else
{
    System.Console.WriteLine($"Число {number2} max ");
}