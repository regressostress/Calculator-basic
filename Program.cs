Console.WriteLine("Добро пожаловать в калькулятор!");
Console.WriteLine("Нажмите Enter для продолжения...");
Console.ReadKey();
while (true) // Цикл нужен для того, чтобы если были какие-то ошибки в написание знаков цикл возвращался в начало.
{
    int a, b;
    char zn;
    Console.Write("Введите первое число: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите знак: ");
    zn = Convert.ToChar(Console.ReadLine());

    Console.Write("Введите второе число: ");
    b = Convert.ToInt32(Console.ReadLine());

    if (zn == '+')
    {
        Console.WriteLine("Ответ: " + (a + b));
    }
    else if (zn == '-')
    {
        Console.WriteLine("Ответ: " + (a - b));
    }
    else if (zn == '*')
    {
        Console.WriteLine("Ответ: " + (a * b));
    }
   else if (zn == '/'&& b == 0)
    {
        Console.WriteLine("На 0 делить нельзя!!!");
        continue;
    }
    else if (zn == '/')
    {
        Console.WriteLine("Ответ: " + (a / b));
    }

    else
    {
        Console.WriteLine("Не известное значение, убедитесь в правильности написания знака (+,-,*,/)");
    }
    
}
