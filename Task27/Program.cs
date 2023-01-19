using static System.Console;

int GetSum(int number)
{
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

WriteLine("Input number: ");

int userNumber = int.Parse(ReadLine()!);

int sumDigits = GetSum(userNumber);

WriteLine($"Сумма цифр в числе: {sumDigits}");