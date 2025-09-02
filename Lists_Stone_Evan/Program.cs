using System.Collections.Generic;

namespace Lists_Stone_Evan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 20"); //writes program #

            //creates and fills the list games with strings of different video game names
            List<string> games = new List<string>
            {
                "Monster Hunter Wilds",
                "Minecraft",
                "Halo Infinite",
                "Sea of Thieves",
                "No Man's Sky"

            };

            //creates and fills the list otherGames with strings of different video game names
            string[] otherGames = new string[]
            {
                "Warhammer 40k Space Marine II",
                "Monster Hunter World",
                "Halo Reach"
            };

            //for each string in games writes the string in console
            foreach (string game in games) 
            {
                Console.WriteLine(game);
            }

            //writes the count of instances in games 
            Console.WriteLine($"\nGames in List: {games.Count}");

            //adds the strings from otherGames
            games.AddRange(otherGames);

            //writes the new count of items in games
            Console.WriteLine($"\nGames in List: {games.Count}");

            //if games contains the string "DOOM: The Dark Ages" writes string "Get out of the way mortally challenged, the Slayer has arrived!" else adds "DOOM: The Dark Ages
            if (games.Contains("DOOM: The Dark Ages"))
            {
                Console.WriteLine("\nGet out of the way mortally challenged, the Slayer has arrived!");
            }
            else
            {
                games.Add("DOOM: The Dark Ages");
            }

            //creates the int. myInt, and assignes it the number 6
            int myInt = 6;

            //if myInt is less than the count of items in games, remove the sixth item, else say "Game not found!"
            if(myInt < games.Count) 
            {
                games.RemoveAt(myInt);
            }
            else
            {
                Console.WriteLine("Game not found!");

            }

            Console.WriteLine("\nAll games in the list: ");  //Writes "all games in the list:
            //for each string in games, writes the string in console
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            //sorts games items
            games.Sort();

            Console.WriteLine("\nSorted Game list: "); //writes "Sorted Game list:
            // for each string in games, write the string in console
            foreach (string game in games)
            {
                Console.WriteLine(game);
            }

            //creates the string sequence newList based on games count
            string[] newList = new string[games.Count];

            //copy games items to newList
            games.CopyTo(newList);

            //clears games
            games.Clear();

            //writes "NewList:"
            Console.WriteLine("\nNewList:");
            //foreach string in newList, writes the string
            foreach (string game in newList)
            {
                Console.WriteLine(game);   
            }
        }
    }
}