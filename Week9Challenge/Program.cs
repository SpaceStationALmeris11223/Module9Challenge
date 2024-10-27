using System;//Allows the usage of basic data types(double) as well as console
using System.Collections.Generic;//This line allows the creations of classes as well as list, dictonarys and other C features
using System.Linq;//THis line allows the usage of linq so we can use database features in our code



namespace VideoGames
{//Create the namespace VideoGames to serve as the programs container.
    public class Game//The game class should be outside the program class. Otherwise It wont work.
    {
        //Atribute (Properties moved to Game class))
        public String Name { get; set; }//creates the public string Name,
         and allowing it to read Properties (get) and change Properties (set)
        public String Genre {get ; set; }//creates the public string Genre,
        //and allowing it to read Properties (get) and change Properties (set)
        public Double Rating{get; set; }//creates the public string Rating,
    }//and allowing it to read Properties (get) and change Properties (set)
    public class Program //the program class should contain both the games list and the LINQ querys
    {
        public static void Main(string[] args)
        {   
        List<Game> games = new List<Game>();//The list where the games are contained 
        games.Add(new Game { Name = "Legend Of Zelda Echoes Of Wisdom", Genre = "Action-Adventure", Rating = 9.0});
        games.Add(new Game { Name = "Pikmin 2", Genre = "Real-Time-Strategy", Rating = 9.3});//Was one of my favortie gamed during my childhood
        games.Add(new Game { Name = "Kirby Planet Robobot", Genre = "Action-Adventure", Rating = 8.0});
        games.Add(new Game { Name = "Carrion", Genre = "Horror", Rating = 9.0});
        games.Add(new Game { Name = "Darkest Dungeon", Genre = "Role Playing", Rating = 9.0});
        games.Add(new Game { Name = "Frost Punk", Genre = "City-Building, Survival", Rating = 9.0});
        games.Add(new Game { Name = "Monster Hunter Tri ", Genre = "Action-Adventure", Rating = 8.8});
        games.Add(new Game { Name = "Poxnora", Genre = "Turn-Based-Strategy", Rating = 7.0});
        games.Add(new Game { Name = "Aragami 2", Genre = "Action-Adventure", Rating = 5.0});
        games.Add(new Game { Name = "Steel Battalion: Heavy Armor ", Genre = "Action-Adventure", Rating = 3.0});
       
        var topRatedGames = (from game in games 
        where game.Rating >=8//The query will sort the games by their ratings allowing only ratings 8 or higher then slap them into a list
        select game).ToList();
                        
        var sortedGames = (from game in topRatedGames
        orderby game.Name//This block of code sorts the games by their names
        select game).ToList();//then throws them into a list in the sorted order
        
            foreach (var game in sortedGames)
            {//This block will write the Games name, genre, and rating onto the terminal
                Console.WriteLine(game.Name);//in a organized list
            }    
        }//End of public static void main
    }//end of Class Program
}//end of namespace