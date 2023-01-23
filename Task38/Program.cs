// Найти разницу между максимальным и минимальным элементом массива

using static System.Console;

WriteLine("Введите количество элементов в массиве: ");

int length = int.Parse(ReadLine()!);
double[] array = GetArray(length);

PrintArray(array);

double arrayDiff = GetDiff(array);

WriteLine($"Разность между максимальным и минимальным элементами массива: {arrayDiff.ToString("F2")}");

double[] GetArray(int size)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    double maximum = 100.0; // это диаппазон вещественных чисел, которые добавляются в массив
    double minimum = 1.0;
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = (rnd.NextDouble() * (maximum - minimum) + minimum);
    }

    return resultArray;
}

double GetDiff(double[] inArray)
{
    double min_elem = inArray[0];
    double max_elem = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        min_elem = inArray[i] < min_elem ? inArray[i] : min_elem;
        max_elem = inArray[i] > max_elem ? inArray[i] : max_elem;
    }

    double diffElem = max_elem - min_elem;

    return diffElem;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{(inArray[i].ToString("F2"))}, ");
    }
    WriteLine($"{inArray[inArray.Length-1].ToString("F2")}]");
}