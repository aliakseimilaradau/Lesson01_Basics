Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] temperatures = { 25, 29, 20, 24, 28, 26, 18 };
int sum = 0;

for (int i = 0; i < temperatures.Length; i++)
{
    Console.WriteLine($"День {i + 1}: {temperatures[i]}");
    sum = sum + temperatures[i];
}

double averageTemperature = Math.Round(((double)sum / temperatures.Length), 1, MidpointRounding.AwayFromZero);

Console.WriteLine($"Средняя температура за 7 дней составляет: {averageTemperature}");