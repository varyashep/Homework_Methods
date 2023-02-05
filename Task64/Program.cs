using static System.Console;

WriteLine("Введите число: ");
int n = int.Parse(ReadLine()!);
WriteLine($"Числа от {n} до 1: ");
GetNumbers(n);

void GetNumbers(int num)
{
    if (num==1) Write(num);
    else
    {
        Write($"{num},");
        GetNumbers(num-1);
    }
}