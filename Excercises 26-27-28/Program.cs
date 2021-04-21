using System;
// Prompt the user to enter text. Count and output how many vowels were in the string.

class VowelCounter
{

    public static bool isVowel(char ch)
    {
        ch = char.ToLower(ch);
        return (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u');

    }

    public static int countVowels(string str)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {

            if (isVowel(str[i]))
            {
                ++count;
            }
        }
        return count;
    }

    public static void Main(string[] args)
    {

        Console.WriteLine("Write me something. ");
        string str = Console.ReadLine();

        Console.WriteLine($"There are {countVowels(str)} vowels.");

//Prompt the user to enter text. Count and output how many consonants are in the string.

        Console.WriteLine("Write me something else. ");
        string sentence = Console.ReadLine().Trim().Replace(" ", "");
        
        {
            for (int i = 1; i < sentence.Length; i++);
        }
        

        Console.WriteLine($"There are {sentence.Length - countVowels(str)} consonants.");

 //Prompt the user to enter text. Remove all the vowels and output the text.

        Console.WriteLine("Write me something else. ");
        string sentence2 = Console.ReadLine();
        

    }


}