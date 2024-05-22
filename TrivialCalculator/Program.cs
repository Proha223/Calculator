static void Main(string[] args)
{
    try
    {
        Console.Write("Введите 1 число: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите действие (+, -, *, /, s(Корень)): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double b = 0;
        if (operation != 's')
        {
            Console.Write("Введите 2 число: ");
            b = double.Parse(Console.ReadLine());
        }

        var calc = new Calculator();

        switch (operation)
        {
            case '+':
                Console.WriteLine("{0}+{1}={2}", a, b, calc.Add(a, b));
                break;
            case '-':
                Console.WriteLine("{0}-{1}={2}", a, b, calc.Substract(a, b));
                break;
            case '*':
                Console.WriteLine("{0}*{1}={2}", a, b, calc.Multiply(a, b));
                break;
            case '/':
                try
                {
                    Console.WriteLine("{0}/{1}={2}", a, b, calc.Divide(a, b));
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на ноль нельзя!");
                }
                break;
            case 's':
                Console.WriteLine("Корень ({0})={1}", a, calc.SquareRoot(a));
                break;
            default:
                Console.WriteLine("Ошибка!");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.ReadKey();
}