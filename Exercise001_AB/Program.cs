// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();
int Text(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int n1  = Text("Enter a base: "); // Вводим основание
int n2  = Text("Enter a extent: "); // Вводим степень

int Construction(int basement, int extent)
{
    int result = 1;
    for (int i = 1; i <= extent; i++)
    {
        result = result * basement;
    }
    return result;
}

Console.Write($"Your value is: {Construction(n1, n2)}");