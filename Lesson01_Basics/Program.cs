Console.OutputEncoding = System.Text.Encoding.UTF8;
string name = "Андрей";   // текст — тип string
int age = 25;             // целое число — тип int
double height = 1.78;     // дробное число — тип double
bool isStudent = true;    // да/нет — тип bool
string favoriteColor = "Black";

Console.WriteLine("Привет, меня зовут " + name);
Console.WriteLine("Мне " + age + " лет");
Console.WriteLine("Мой рост: " + height + " м");
Console.WriteLine("Я студент: " + isStudent);
Console.WriteLine($"Мой любымый цвет {favoriteColor}");