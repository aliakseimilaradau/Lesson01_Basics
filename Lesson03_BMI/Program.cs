Console.OutputEncoding = System.Text.Encoding.UTF8;

double AskWeight()
{
    Console.WriteLine("Укажите ваш вес в килограммах");
    string inputWeight = Console.ReadLine();
    double weight = double.Parse(inputWeight);
    while (weight <= 0)
    {
        Console.WriteLine("Вес указан не верно. Повторите ввод.");
        string input = Console.ReadLine();
        double userWeight = double.Parse(input);
    }
    return weight;
}

double AskHeight()
{
    Console.WriteLine("Укажите ваш рост в метрах");
    string inputHeight = Console.ReadLine();
    double height = double.Parse(inputHeight);
    while (height <= 0)
    {
        Console.WriteLine("Рост указан не верно. Повторите ввод.");
        string input = Console.ReadLine();
        double userHeight = double.Parse(input);
    }
    return height;
}

double weight = AskWeight();
double height = AskHeight();

double bmi = weight/(height * height);

if (bmi < 18.5)
{
    Console.WriteLine($"Недостаточный вес. bmi = {bmi}");
}
else if (bmi < 24.9)
{
    Console.WriteLine($"Норма. bmi = {bmi}");
}
else  if (bmi < 29.9)
{
    Console.WriteLine($"Избыточный вес. bmi = {bmi}");
}
else
{
    Console.WriteLine($"Ожирение. bmi = {bmi}");
}