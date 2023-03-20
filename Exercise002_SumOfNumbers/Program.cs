// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int Enterance(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int n = Enterance("Enter a number: ");

int Sum(int number)
{
    int count = 0;
    while (n >= 1)
    {
        count = count + n % 10;
        n = n / 10;
    }
    return count;
}

Console.Write($"Your result is: {Sum(n)}");