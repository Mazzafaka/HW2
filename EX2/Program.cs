// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int GetThirdDigit(int random)
    {
        if (Math.Abs(random) < 100)
        {
            return -1; 
        }

        int posNumber = Math.Abs(random);
        int mNumber = posNumber % 10;

        return mNumber;
    }
Console.WriteLine("Введите число");
int random = int.Parse(Console.ReadLine());
int mNumber = GetThirdDigit(random);
if (mNumber != -1)
        {
            Console.WriteLine("Третья цифра числа: " + mNumber);
        }
        else
        {
            Console.WriteLine("У числа нет третьей цифры.");
        }
Console.WriteLine($"{random} -> {mNumber}");
