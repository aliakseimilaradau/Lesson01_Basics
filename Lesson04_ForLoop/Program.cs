Console.OutputEncoding = System.Text.Encoding.UTF8;

int AskNumber ()
{
    Console.WriteLine("Введите число:");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    while (number <= 0)
    {
        Console.WriteLine("Введите положительное число");
        input = Console.ReadLine();
        number = int.Parse(input);
    }
    return number;
}

int number = AskNumber ();
int sum = 0;

for (int i = 1; i <= number; i++)
{
    int remainder = number % i;
        if (remainder == 0)
    {
        Console.WriteLine($"Делитель: {i}");
        if (i != number)
        {
            sum = (sum + i);
        }
    }
}

if (sum == number)
{
    Console.WriteLine("Это совершенное число!");
}
else
{
    Console.WriteLine($"Сумма: {sum}");
}