// Заполнить массив положительными трехзначными числами и посчитать количество четных чисел в массиве 

using static System.Console;


WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);

int[] array = GetArray(size);
PrintArray(array);

int evenNumbers = CountEven(array);
Write($"Количество четных чисел в массиве: {evenNumbers}");

int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] resultArray  = new int[length];

    for (int i = 0; i < length; i++)
    {
        resultArray[i] = rnd.Next(100,1000);
    }

    return resultArray;
}

int CountEven(int[] inArray)
{
    int count = 0;

    foreach(int a in inArray)
    {
        count += a % 2 == 0 ? 1 : 0;
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