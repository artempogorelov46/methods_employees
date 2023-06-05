using System;
using System.Text;
namespace Game;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "World of elements";
        Dialogues dialogues = new Dialogues();
        Console.WriteLine("               Введите имя персонажа");
        string name = Convert.ToString(Console.ReadLine());
        Player player = new Player(name,1,200,1000);
        dialogues.BeginGame();
        dialogues.Chapter1();
        Console.ReadKey();
    }
}