using System.Diagnostics.Tracing;

namespace Adopt_An_Insect
{
class Food
{
    public string Type;
    public string Effect;
    public Food(string type, string effect)
    {
        Type = type;
        Effect = effect;
    }

    public void FoodChoice()
    {   
        Console.WriteLine("Now, your pet insect is looking a little hungry. What do you want to feed him?");
        Console.WriteLine("Sorry... It looks like I only have human food... I'm sure it won't leave any effects...");
        Console.WriteLine("Type a number to choose");
        Console.WriteLine(" 1) Hamburger 2) Pizza 3) Noodles ");
        string choice = Console.ReadLine();
         switch (choice)
            {
                case "1":
                    Type = "hamburger";
                    break;
                case "2":
                    Type = "pizza";
                    break;
                case "3":
                    Type = "noodles";
                    break;
                default:
                    Console.WriteLine("Hmm... I'm not sure what that means. I guess I'll just give it a bowl of cereal.");
                    Type = "cereal";
                    break;
            }
            
            FoodEffect();
    }
    public void FoodEffect()
    {
        Console.WriteLine($"Alright, let's feed him {Type}");
        if (Type == "hamburger"){
            Console.WriteLine("Hmmm... It seems like the hamburger has made your insect float slightly above the ground...");
            Console.WriteLine("That's a strange effect for a hamburger to have.. But it doesn't seem to be bothering him?");
            Console.WriteLine("I'm sure if it really bothers you, you could just like, gently hold him to the ground with your finger? Or tape him down?");
        }
        else if (Type == "pizza"){
            Console.WriteLine("Hmm... It seems like the pizza made your insect invisible...");
            Console.WriteLine("I mean, I'm sure it'll wear off eventually.");
        }
        else if (Type == "noodles"){
            Console.WriteLine("Hmm... It seems like the noodles made him turn into an eldtrich god the likes of which the world has never seen.");
            Console.WriteLine("He's all powerful, and capable of world domination... It's a good thing he still has the brain of an insect");
            Console.WriteLine("I mean, that's pretty neat, right?");
        }
        else if (Type == "cereal"){
            Console.WriteLine("Hmm... He seems uneffected by the cereal...");
            Console.WriteLine("How boring.");
        }
        else{
            Console.WriteLine("Hmm... I guess he's not really that hungry.");
        }
        
        Console.WriteLine("Well.. now that he's eaten."); 

       

    }
}
}