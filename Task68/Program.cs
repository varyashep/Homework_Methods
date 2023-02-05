using static System.Console;


WriteLine("Введите два числа через пробел: ");
int[] parameters = Array.ConvertAll(ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries), int.Parse);
int result = A(parameters[0], parameters[1]);
WriteLine($"A(m,n) = {result}");

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return A(m-1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return A(m-1, A(m,n-1));
    }
    else
    {
        return 0;
    }
}