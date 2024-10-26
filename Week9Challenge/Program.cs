using System;
using System.Collections.Generic;
using System.Linq;



namespace VideoGames
{

    public class Game
    {
        //Atribute (Properties moced to Game class))
        public String Name { get; set; }
        public String Genre {get ; set; }
        public Double Rating{get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {   
        List<Game> games = new List<Game>();
        games.Add(new Game { Name = "Legend Of Zelda Echoes Of Wisdom", Genre = "Action-Adventure", Rating = 9.0});
        games.Add(new Game { Name = "Pikmin 2", Genre = "Real-Time-Strategy", Rating = 9.3});
        games.Add(new Game { Name = "Kirby Planet Robobot", Genre = "Action-Adventure", Rating = 8.0});
        games.Add(new Game { Name = "Carrion", Genre = "Horror", Rating = 9.0});
        games.Add(new Game { Name = "Darkest Dungeon", Genre = "Role Playing", Rating = 9.0});
        games.Add(new Game { Name = "Frost Punk", Genre = "City-Building, Survival", Rating = 9.0});
        games.Add(new Game { Name = "Monster Hunter Tri ", Genre = "Action-Adventure", Rating = 8.8});
        games.Add(new Game { Name = "Poxnora", Genre = "Turn-Based-Strategy", Rating = 7.0});
        games.Add(new Game { Name = "Aragami 2", Genre = "Action-Adventure", Rating = 5.0});
        games.Add(new Game { Name = "Steel Battalion: Heavy Armor ", Genre = "Action-Adventure", Rating = 3.0});
       
        var topRatedGames = (from game in games 
        where game.Rating >=8
        select game).ToList();
                        
        var sortedGames = (from game in topRatedGames
        orderby game.Name
        select game).ToList();
        
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }    
        }
    }
}
