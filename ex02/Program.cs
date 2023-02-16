// Показать натуральные числа от N до 1, N задано


int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

void CalcNat(int arg)
{
    if (arg > 0) 
    {
        Console.WriteLine(arg);
        CalcNat(arg - 1);
    }
}

int N = ReadInt("Введите число N: ");

CalcNat(N);