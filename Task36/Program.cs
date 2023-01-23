// Подсчет суммы элементов на нечетных позициях

using static System.Console;

WriteLine("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

int[] array = GetArray(length);

PrintArray(array);

int sumUneven = CountUneven(array);

WriteLine($"Сумма элементов на нечетных позициях: {sumUneven}");

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(-100,100); // здесь в целом можно задать любой диапазон, для наглядности выбираем небольшой
    }

    return resultArray;
}

int CountUneven(int[] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        sum += i % 2 != 0 ? inArray[i] : 0;
    }

    return sum;
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