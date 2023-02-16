// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int ReadInt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int fib(int arg1, int arg2, int n)
{
    if (n == 1 ) return arg1;
    if (n == 2) return arg2;
    else return fib(arg1, arg2, n-1) + fib(arg1, arg2, n - 2);
}

void Printfib(int a, int b, int M)
{
    for (int i = 1; i <= M; i++)
    {
        Console.WriteLine($"{i} {fib(a,b,i)}");
    }
}

int a = ReadInt("Введите первое число ряда: ");
int b = ReadInt("Введите второе число ряда: ");
int M = ReadInt("Введите до какого числа необходимо выводить ряд: ");

Printfib(a, b, M);