// Найти сумму элементов от M до N через рекурсию, N и M заданы


int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int CalcNat(int arg, int n)
{
    if (arg > n) return 0;
    else return arg + CalcNat(arg + 1, n);
}

int N = ReadInt("Введите число N: ");
int M = ReadInt("Введите число M: ");

Console.WriteLine(CalcNat(N, M));
