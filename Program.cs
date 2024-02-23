string [] CreateMass(int str)
{
    string [] mass = new string [str];
    string inmass = "";
    int i = 0;
    while (inmass != "q")
    {
        Console.WriteLine("Введите элементы массива или q для завершения ввода");
        inmass = Convert.ToString(Console.ReadLine());
        if (inmass != "q")
        {
            mass[i] = inmass;
            i++;
        }
        
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
        if (e.Length < 3)
        {
            Console.Write($"{e} ,");
        }
    }
}
string [] mass = CreateMass(30);
MassPrint(mass);
PrintStrLess3(mass);