using System;

namespace PigLatinAssignment
{
    class Program
    {
        static void Main(string[] args)

        {
            bool goOn = true;
            while (goOn == true)
            {
                Console.WriteLine("Pig Latin Tanslator");
                Console.WriteLine();

                Console.Write("Enter word: ");
                string Word = Console.ReadLine().ToLower();

                int VowelPosition = -1;
                foreach (char letter in Word)
                {
                    VowelPosition = VowelPosition + 1;
                    if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        break;
                    }

                }
                string PigLatinWord = "";
                string BeforeLetters = "";
                string AfterLetters = "";
                switch (VowelPosition)
                {
                    case 0:
                        PigLatinWord = Word + "way";
                        break;
                    case 1:
                        BeforeLetters = Word.Substring(0, 1);
                        AfterLetters = Word.Substring(1);
                        PigLatinWord = AfterLetters + BeforeLetters + "ay";

                        break;
                    case 2:
                        BeforeLetters = Word.Substring(0, 2);
                        AfterLetters = Word.Substring(2);
                        PigLatinWord = AfterLetters + BeforeLetters + "ay";
                        break;
                    default:
                        PigLatinWord = "Unable to translate";
                        break;

                }
                Console.WriteLine("Translation: " + PigLatinWord);
                goOn = GetContinue();
            }
            static bool GetContinue()
            {
                Console.WriteLine("Would you like to translate another word? (y/n)");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    return true;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");
                    return GetContinue();

                }
            }
        }
    }
}
