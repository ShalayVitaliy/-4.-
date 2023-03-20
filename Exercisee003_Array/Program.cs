// Задача 29: Напишите программу, которая будет создавать массив из 8 символов и заполнять значениями от пользователя


Console.Clear();

int Enterance(string message)
{
    System.Console.Write(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] MakeArray(int Size)
{
    int[] array = new int[Size];
    for (int i = 0; i < Size; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine(" ]");
}

int Length = Enterance("Enter a size of array: ");
int[] array = MakeArray(Length);
PrintArray(array);