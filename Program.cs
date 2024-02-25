string[] CreateArr(int str)
{
    string[] mass = new string[str];
    string inmass = "";
    for (int i = 0; i < str; i++)
    {
        Console.WriteLine("Введите элементы массива");
        inmass = Convert.ToString(Console.ReadLine()!);
        mass[i] = inmass;
    }
    return mass;
}
string [] CreateNewArrLenStrLes(int len, string[] arr)
{
    int count = 0;
    foreach (string i in arr)
    {
        if (i.Length < len)
        {
            count++;
        }
    }
    string [] newarr = new string [count];
    int j = 0;
    foreach(string e in arr)
    {
        if (e.Length < len)
        {
            newarr[j] = e;
            j++;
        }
    }
    return newarr;
}
void PrintArr(string [] arr)
{
    foreach(string i in arr)
    {
        Console.Write($"{i} ");
    }
}
Console.Clear();
Console.WriteLine("Введите размер массива ");
int len = int.Parse(Console.ReadLine()!);
string[] arr = CreateArr(len);
Console.WriteLine("Ваш массив:");
PrintArr(arr);
Console.WriteLine();
Console.WriteLine("Введите значение длины строки меньше которой включаем в массив:");
int less = int.Parse(Console.ReadLine()!);
Console.WriteLine("Результат:");
PrintArr(CreateNewArrLenStrLes(less, arr));
