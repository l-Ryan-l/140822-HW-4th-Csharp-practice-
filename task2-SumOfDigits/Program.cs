// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ (int userNumber)
{
    int result = 0;
    int sum = 0;

        while(userNumber > 0)
        {
            sum = result + userNumber % 10; 
            result = sum; 
            userNumber = userNumber/ 10;
        }
        return sum;
}

Console.WriteLine("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!);

int sum = Summ (userNumber);
Console.WriteLine(sum);