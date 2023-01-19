// Метод принимает на вход два числа A и B и возводит А в степень B
using static System.Console;

int GetDegree(int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

WriteLine("Input number A: ");

int A = int.Parse(ReadLine()!);

WriteLine("Input number B: ");

int B = int.Parse(ReadLine()!);

int finalNumber = GetDegree(A,B);

WriteLine($"Final number: {finalNumber}");