// Показать натуральные числа от 1 до N, N задано

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

CalcNat(N, 1);