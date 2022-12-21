Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень");
int pow = int.Parse(Console.ReadLine()!);
WrongPower();

void WrongPower()
{
    int result = 1;
    for (int i = 0; i < pow; i++)
    {
        result = result * number;
    }
    Console.WriteLine(result);
}

int Power(int a, int b)
{
    if (b < 0)
    {
        b = -b;
    }
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}