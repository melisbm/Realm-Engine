using Realm_Engine.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Warrior myWarrior = new Warrior("Finn");
        Console.WriteLine(myWarrior.Name);
        Console.WriteLine(myWarrior.Hp);
    }
}