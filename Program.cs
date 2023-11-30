Console.Clear();

Console.Write("Введите количество элементов массива: ");
int numberOfelements = Convert.ToInt32(Console.ReadLine());
string[] newArray = new string[numberOfelements];
for (int i = 0; i < numberOfelements; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    newArray[i] = Console.ReadLine();
}

string fillArray = string.Join(" ", newArray);
Console.WriteLine("\nВведенный вами масив данных: ");
Console.WriteLine(fillArray);

string[] NewArrayWithElementsThetLessThenThree(string[] array)
{
    int sumOfElementsThatLessThanThree = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sumOfElementsThatLessThanThree++;
        }
    }
}


Console.ReadKey();


