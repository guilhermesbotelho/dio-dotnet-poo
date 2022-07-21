using dio_poo_dotnet.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        Knight Arus = new Knight("Arus", 42, 749, 72, "Axe");
        Ninja Wedge = new Ninja("Wedge", 42, 574, 89, "Kunai");
        Wizard Jenica = new Wizard("Jenica", 42, 601, 482, "White");
        Wizard Topapa = new Wizard("Topapa", 42, 385, 641, "Black");

        Console.WriteLine(Arus.HealthPoints);
        Arus.damage(750);
        Console.WriteLine(Arus.HealthPoints);

        Console.WriteLine(Arus.ManaPoints);
        Arus.castSpell(30);
        Console.WriteLine(Arus.ManaPoints);

        Console.WriteLine(Arus.ShowStats());
        Console.WriteLine(Wedge.ShowStats());
        Console.WriteLine(Jenica.ShowStats());
        Console.WriteLine(Topapa.ShowStats());

    }
}