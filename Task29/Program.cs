// Массив случайных чисел из 8 элементов 
using static System.Console;

void RandomArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next();
        Write(array[i] + " ");
    }
}

RandomArray(8);