Console.WriteLine("p\tq\tp AND q");
Console.WriteLine("------------------");
for (int i = 0; i <= 1; i++)
{
    for (int j = 0; j <= 1; j++)
    {
        bool p = Convert.ToBoolean(i);
        bool q = Convert.ToBoolean(j);
        bool resultado = p && q;
        Console.WriteLine($"{p}\t{q}\t{resultado}");
    }
}