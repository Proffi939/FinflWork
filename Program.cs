string [] CreateMass(int str)
{
    string [] mass = new string [str];
    string inmass = "";
    for (int i =0; i < str; i++)
    {
        Console.WriteLine("Введите элементы массива");
        inmass = Convert.ToString(Console.ReadLine());
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
    foreach(string e in mass)
    {
        if (e.Length < 4)
        {
            Console.Write($"{e} ,");
        }
    }
}
Console.WriteLine("Введите размер массива ");
int len = int.Parse(Console.ReadLine()!);
string [] mass = CreateMass(len);
MassPrint(mass);
PrintStrLess3(mass);