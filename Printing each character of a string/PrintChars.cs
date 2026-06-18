using System;

namespace Printing_each_character_of_a_string;

public class PrintChars
{
    public static void PrintTextChar(string text, int index)
    {
        if(index == text.Length)
        {
            return;
        }

        Console.WriteLine(text[index]);
        PrintTextChar(text, index + 1);
    }   

}
