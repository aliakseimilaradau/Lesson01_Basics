Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] grades = { 75, 34, 56, 90, 65, 100, 1 };
int sum = 0;
int max = grades[0];
int min = grades[0];

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Оценка {i + 1}: {grades[i]}");
    sum = sum + grades[i];

    if (grades[i] > max)
    {
        max = grades[i];
    }

    if (grades[i] < min)
    {
        min = grades[i];
    }
}

double averageGrades = Math.Round(((double)sum / grades.Length), 1, MidpointRounding.AwayFromZero);

Console.WriteLine($"Сумма баллов: {sum}");
Console.WriteLine($"Средний балл: {averageGrades}");
Console.WriteLine($"Максимальный балл: {max}");
Console.WriteLine($"Минимальный балл: {min}");