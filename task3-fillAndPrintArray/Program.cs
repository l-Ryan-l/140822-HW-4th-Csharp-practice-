// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int limit)
{
    int[] numbersArray = new int[limit];
    var rnd = new Random();
    for (int i = 0; i < limit; i++)
    {
        numbersArray[i] = rnd.Next(limit);
    } 
    return numbersArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите диапазон чисел (до какого числа) для наполнения массива: ");
int limit = int.Parse(Console.ReadLine()!);

int[] array = FillArray(limit);
PrintArray(array);