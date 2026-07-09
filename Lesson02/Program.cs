Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Как тебя зовут?");
string userName = Console.ReadLine();

void PrintGreeting (string name)
{
    Console.WriteLine($"Привет, {name}!!!");
}

PrintGreeting(userName);

int AskAge ()
{
    Console.WriteLine("Сколько тебе лет?");
    string ageInput = Console.ReadLine();
    int userAge = int.Parse(ageInput);
    
    while (userAge < 0 || userAge >120)
    {
        Console.WriteLine("Введите корректный возраст (0 - 120):");
        string input = Console.ReadLine();
        userAge = int.Parse(input);
    }
        return userAge;
}

int userAge = AskAge();

Console.WriteLine($"Принято: {userAge}");

if (userAge < 18)
{
    Console.WriteLine("Ты несовершеннолетний");
}
else if (userAge <= 65)
{
    Console.WriteLine("Ты совершеннолетний");
}
else
{
    Console.WriteLine("Ты можешь выйти на пенсию");
}