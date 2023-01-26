using static System.Console;
// Посчитать количество чисел больше 0
WriteLine("Введите числа: ");

string[] stringNumbers = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] numbers = ConvertToInt(stringNumbers);
PrintArray(numbers);

int countPos = CountPositives(numbers);
WriteLine($"Количество чисел больше нуля: {countPos}");

int[] ConvertToInt(string[] inArray)
{
    int[] convertArray = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        convertArray[i] = int.Parse(inArray[i]);
    }
    return convertArray;
}

int CountPositives(int[] inArray)
{
    int count = 0;

    foreach(int a in inArray)
    {
        count += a > 0 ? 1 : 0;
    }

    return count;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    WriteLine($"{inArray[inArray.Length-1]}]");
}