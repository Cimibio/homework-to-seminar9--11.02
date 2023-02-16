// Найти сумму цифр числа через рекурсию


int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int CalcSum(int arg)
{
    if (arg == 0) return 0;
    else return arg % 10 + CalcSum(arg / 10);
}

int N = ReadInt("Введите число N: ");

Console.WriteLine(CalcSum(N));