using System;
using static System.Console;

namespace Adopt_An_Insect
{
    class Game
    {
        Player player;
        string GameTitle = "Adopt an Insect!";

        public Game()
        {
            player = new Player();
        }
        public Game(string title)
        {
            GameTitle = title;
            player = new Player();
        }

        public void Start()
        {
            Title = GameTitle;
            GetNamePlayer();
        }

        public void GetNamePlayer(){
            //Get player's name and save it to the instance of player class
            WriteLine("Welcome to Adopt An Insect!");
            WriteLine("What is your name?");
            player.Name = Console.ReadLine();
            Greeting();

        }
        public void Greeting(){
            //greet player with the name they entered
            WriteLine("It's nice to meet you " + player.Name + "!");
            WriteLine($"Now, it's time to adopt your insect.");
            GetNameInsect();
        }

        public void GetNameInsect(){
            //get name for player's insect
            WriteLine("What would you like to name your insect?");
            player.PlayerInsect.Name = ReadLine();
            WriteLine("Great Choice!");
            ColorInsect();
            }
        
        public void ColorInsect(){
            //get color for insect
            WriteLine("Type a number for a color:");
            WriteLine(" 1) Blue 2) Red 3) Green 4) Yellow 5) Black 6) Purple ");
            string choice = ReadLine();
            switch (choice)
            {
                case "1":
                    player.PlayerInsect.Color = "blue";
                    break;
                case "2":
                    player.PlayerInsect.Color = "red";
                    break;
                case "3":
                    player.PlayerInsect.Color = "green";
                    break;
                case "4":
                    player.PlayerInsect.Color = "yellow";
                    break;
                case "5":
                    player.PlayerInsect.Color = "black";
                    break;
                case "6":
                    player.PlayerInsect.Color = "purple";
                    break;
                default:
                    WriteLine("Hmm... I'm not sure what that means. Let's go with pink!");
                    player.PlayerInsect.Color = "pink";
                    break;
            }
            PrintNameColor();
        }
        public void PrintNameColor(){
            //print summary of player's insect (name and color)
            Clear();
            WriteLine($"Congratulations {player.Name}! You have adopted a {player.PlayerInsect.Color} insect named {player.PlayerInsect.Name}.");
            //ReadKey();
            WriteLine("Hit enter to continue.");
            Console.ReadKey();
            Food food = new Food("Pizza", "Will make your insect fluffy.");
            food.FoodChoice();

            SleepTime();
        }

        public void SleepTime(){
            Console.WriteLine("Hit enter to continue.");
            Console.ReadKey();
            Clear();
            WriteLine($"Alright, well I think {player.PlayerInsect.Name} has had a lot of fun for today. Let's let them sleep for now. See you next time {player.Name}");
        }
        
        }
    }