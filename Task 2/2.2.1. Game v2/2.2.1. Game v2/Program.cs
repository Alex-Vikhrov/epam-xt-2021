using System;
using UsefulConsoleTool;

namespace _2._2._1._Game_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameFlash game = new GameFlash(new WeatherMap());
            game.Initialize();

            Console.WriteLine("** Параметры персонажа **");
            Player flash = new Player();
            Console.WriteLine("Задайте параметры персонажу Flash:" + Environment.NewLine + "1) Heigt:");
            int value = ConsoleHelper.ReadIntValue();
            flash.Height = value;

            Console.WriteLine("2) Speed:");
            ConsoleHelper.ReadIntValue();
            flash.Speed = value;

            Console.WriteLine("3) Force:");
            ConsoleHelper.ReadIntValue();
            flash.Force = value;

            Enemies zoom = new Enemies();
            zoom.GetEnemis();
        }
    }
}
