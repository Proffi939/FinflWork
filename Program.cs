string [] CreateMass(int str)
{
    string [] mass = new string [str];
    string inmass = "";
    for (int i =0; i < str; i++)
    {
        Console.WriteLine("Введите элементы массива");
        inmass = Convert.ToString(Console.ReadLine()!);
        mass[i] = inmass;
    } 
    return mass;
}
void MassPrint(string [] mass)
{
    Console.WriteLine("Ваш массив ");
    foreach (string i in mass)
    {
        Console.Write($"{i} ");
    }
}
void PrintStrLess3(string [] mass)
{
    Console.WriteLine("Массив с элементами меньше или равно 3");
    int count = 0;
    foreach(string e in mass)
    {
        if (e.Length < 4)
        {
            Console.Write($"{e} ");
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Элементов нет");
    } 
}
Console.Clear();
Console.WriteLine("Введите размер массива ");
int len = int.Parse(Console.ReadLine()!);
string [] mass = CreateMass(len);
Console.WriteLine();
MassPrint(mass);
Console.WriteLine();
PrintStrLess3(mass);