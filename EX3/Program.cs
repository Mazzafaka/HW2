// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

    bool IsWeekend(int dayOfWeek)
    {
        return dayOfWeek == 6 || dayOfWeek == 7;
    }
    Console.Write("Введите цифру, обозначающую день недели: ");
    int dayOfWeek = int.Parse(Console.ReadLine());
    bool isWeekend = IsWeekend(dayOfWeek);

    if (isWeekend){
        Console.WriteLine("День является выходным.");
    }
    else{
        Console.WriteLine("День не является выходным.");
    }