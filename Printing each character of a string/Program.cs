namespace Printing_each_character_of_a_string;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===================================");
        Console.WriteLine("Printing each character of a string");
        Console.WriteLine("===================================");
        string testInput = "";

        int choice = 0;
        int num = 0;

        do
        {
            Console.Write("Enter Text: ");

            testInput = Console.ReadLine() ?? "";

            PrintChars.PrintTextChar(testInput, 0);

            Console.Write("Do you want to Continue? Press 1 if YES then 0 if NO: ");
            while (true)
            {
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    
                    if(num == 1)
                    {
                        Console.WriteLine("You Entered 1 so we will continue!");
                        choice = num;
                    }
                    else if(num == 0)
                    {
                        Console.WriteLine("Your Entered 0, GoodBye");
                        choice = num;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input, Only Enter 1 or 0 to Continue");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
            
        }while(choice == 1);
        
    }
}
