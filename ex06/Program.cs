// Написать программу вычисления функции Аккермана через рекурсию

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);
}

int N = ReadInt("Введите число N: ");
int M = ReadInt("Введите число M: ");

Console.WriteLine($"Значение функции Аккермана равно: {Akkerman(N, M)}");
