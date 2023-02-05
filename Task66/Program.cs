using static System.Console;

WriteLine("Введите два числа через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse);
int sum = GetSum(parameters[0], parameters[1]);
WriteLine($"Сумма чисел от {parameters[0]} до {parameters[1]}: {sum}");

int GetSum(int m, int n)
{
    int result = 0;
    if (n==m) return result + m;
    else
    {
        result += n;
        return result + GetSum(m,n-1);
    }
}