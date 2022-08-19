// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power (int numberA, int numberB)
{
int result = 1;
int index = 1;
while (index < numberB +1 )
    {
        result = Convert.ToInt32(numberA * result);
        index++;
    }
return result;
}

Console.WriteLine("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int result = Power (numberA, numberB);
Console.WriteLine(result);

