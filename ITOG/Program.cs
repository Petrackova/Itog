int lenght = 4;
Console.WriteLine("Введите массив содержащий 4 элемента через ENTER:");
string[] result = new string[lenght];
string[] newarr = new string[lenght];
for (int i = 0; i < lenght; i++)
{
    result[i] = Console.ReadLine();
}
for (int i = 0; i < result.Length; i++)
{
    if (result[i].Length <= 3)
    {
        newarr[i] = result[i];
    }
}
newarr = newarr.Where(e => e != null).ToArray();
if (newarr.Length !=0)
{
    for (int i = 0; i < newarr.Length; i++)
    {
        Console.Write("[" + $"{newarr[i]}" + "]" + " ");
    }
}
else
{
    Console.WriteLine("[]");
}