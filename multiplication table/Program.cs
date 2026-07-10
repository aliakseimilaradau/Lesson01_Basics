Console.OutputEncoding =  System.Text.Encoding.UTF8;

Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int number = int.Parse(input);

for (int i = 1; i <= 10; i++)
{
        Console.WriteLine($"{number} x {i} = {number * i}");
}