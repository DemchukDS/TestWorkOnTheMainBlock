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

void NewArrayWithElementsThetLessThenThree(string[] array)
{
    int sumOfElementsThatLessThanThree = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sumOfElementsThatLessThanThree++;
        }
    }
    string[] newArray = new string[sumOfElementsThatLessThanThree];
    if (sumOfElementsThatLessThanThree != 0)
    {
        for (int j = 0; j < sumOfElementsThatLessThanThree; j++)
        {
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k].Length <= 3)
                {
                    newArray[j] = array[k];
                    j++;
                }
            }
        }
        string fillNewArray = string.Join(" ", newArray);
        Console.WriteLine("\nМассив из символов, которые меньше либо равны 3: ");
        Console.WriteLine(fillNewArray);
    }
    else
    {
        Console.WriteLine("\nНет элементов массива, количество символов в котором равно или меньше 3!");
    }
}
NewArrayWithElementsThetLessThenThree(newArray);
Console.ReadKey();


