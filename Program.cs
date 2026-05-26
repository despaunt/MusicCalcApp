using System;

class Program
{
    // ── Арифметические операции (будут реализованы в отдельных ветках) ───────

    static double Add(double a, double b)
        => a + b;

    static double Subtract(double a, double b)
        => throw new NotImplementedException("Subtract: см. ветку feature/subtract");

    static double Multiply(double a, double b)
        => throw new NotImplementedException("Multiply: см. ветку feature/multiply");

    static double Divide(double a, double b)
        => throw new NotImplementedException("Divide: см. ветку feature/divide");

    // ── Меню ─────────────────────────────────────────────────────────────────

    static void Main(string[] args)
    {
        Console.Write("Введите A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию:  1 (+)   2 (-)   3 (*)   4 (/)");
        int op = int.Parse(Console.ReadLine());

        double result;
        switch (op)
        {
            case 1:  result = Add(a, b);      break;
            case 2:  result = Subtract(a, b); break;
            case 3:  result = Multiply(a, b); break;
            case 4:  result = Divide(a, b);   break;
            default:
                Console.WriteLine("Неверная операция");
                return;
        }
        Console.WriteLine($"Результат: {result}");
    }
}
