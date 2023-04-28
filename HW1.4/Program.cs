System.Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int i = 1;
bool not = true;

System.Console.WriteLine("Четные числа от 1 до " + num);
while (i <= num)
{
    if(i % 2 != 1)
    {
        Console.Write(i + ",");
        not = false;
    }
    i++;
}
if(not)
{
    Console.WriteLine("Нет четных чисел");
}
