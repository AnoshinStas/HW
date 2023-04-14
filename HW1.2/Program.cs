System.Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число");
int number2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число");
int number3 = int.Parse(Console.ReadLine());

int Max = number1;
if(number1 < number2) Max = number2;
if(number2 < number3) Max = number3;
System.Console.WriteLine($"Max {Max}");