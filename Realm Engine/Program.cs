using Realm_Engine;
using Realm_Engine.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Warrior myWarrior = new Warrior("Finn");
        Console.WriteLine(myWarrior.Name);
        Console.WriteLine(myWarrior.Hp);

        Player player = new Player("Jake");
        Console.WriteLine(player.Name);
    }
}