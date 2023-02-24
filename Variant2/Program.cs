int lenght = 4;
Console.WriteLine("Введите массив содержащий 4 элемента через ENTER:");
string[] result = Arr(lenght);
string[] newarr = FindMass(result);
PrintArr(newarr);

string[] Arr(int lenght)
{
    string[] result = new string[lenght];
    for (int i = 0; i < lenght; i++)
    {
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] FindMass(string[] arr)
{
    string[] result = new string[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[i] = arr[i];
        }
    }
    result = result.Where(e => e != null).ToArray();
    return result;
}

void PrintArr(string[] arr)
{
    if (arr.Length != 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[" + $"{arr[i]}" + "]" + " ");
        }
    }
    else
    {
        Console.WriteLine("[]");
    }
}