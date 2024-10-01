using System;

public class Program

{
    public static void Main(string[] args)

    {
        
        Reference reference = new Reference("Alma", 26, 27);
        Scripture scripture = new Scripture(reference, "Now when our hearts were depressed, and we were about to turn back, behold, the Lord comforted us, and said: Go amongst thy brethren, the Lamanites, and bear with patience thine afflictions, and I will give unto you success.");

        
        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            
            scripture.HideRandomWords(3); 
        }

        if (scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("\nAll words are hidden. Well done!");
        }
    }
}
