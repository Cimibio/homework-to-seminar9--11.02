// Написать программу возведения числа А в целую степень B через рекурсию

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int Calc(int n, int m)
{
    if (m == 0)return 1;
    else return Calc(n, m - 1) * n;
}

int N = ReadInt("Введите число N: ");
int M = ReadInt("Введите степень: ");

Console.WriteLine(Calc(N, M));
