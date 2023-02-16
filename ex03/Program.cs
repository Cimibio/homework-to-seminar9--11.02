// Показать натуральные числа от M до N через рекурсию, N и M заданы

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void CalcNat(int arg, int n)
{
    if (arg > 0) 
    {
        Console.WriteLine(n);
        n++;
        CalcNat(arg - 1,n);
    }
}

int N = ReadInt("Введите число N: ");
int M = ReadInt("Введите число M: ");

CalcNat(N - M + 1, M);