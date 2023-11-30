Console.Clear();

Console.Write("Введите количество элементов массива: ");
int numberOfelements = Convert.ToInt32(Console.ReadLine());
string[] newArray = new string[numberOfelements];

string[] FillArray(string[] array, int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string fillArray = string.Join(" ", FillArray(newArray, numberOfelements));
Console.WriteLine(fillArray);

Console.ReadKey();


