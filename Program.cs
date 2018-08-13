/*
Morse Code Converter from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-25  

Morse code is a method of transmitting text information as a series of on-off tones, lights, or clicks. 
Each letter or numeral is represented by a unique sequence of dots and dashes. 

Write a program that takes a string as input and converts it into Morse code. 

Some Examples: 
Input: SOS 
Output: ... --- ... 

Input: SoloLearn 
Output: ... --- .-.. --- .-.. . .- .-. -. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeConverter
{
    class Program
    {
        static Dictionary<char, string> dictionary = new Dictionary<char, string>();

        static void Main(string[] args)
        {
            InitDictionary();

            string input = "SOS SoloLearn";  // Insert text to convert in Morse Code

            string output = "";

            foreach(char ch in input)
            {
                char c = Char.ToUpper(ch);

                if(dictionary.ContainsKey(c) == true)
                    output += dictionary[c] + " ";
            }

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {output}");
        }

        static void InitDictionary()
        {

            dictionary.Add('A', ".-");
            dictionary.Add('B', "-...");
            dictionary.Add('C', "-.-.");
            dictionary.Add('D', "-..");
            dictionary.Add('E', ".");
            dictionary.Add('F', "..-.");
            dictionary.Add('G', "--.");
            dictionary.Add('H', "....");
            dictionary.Add('I', "..");
            dictionary.Add('J', ".---");
            dictionary.Add('K', "-.-");
            dictionary.Add('L', ".-..");
            dictionary.Add('M', "--");
            dictionary.Add('N', "-.");
            dictionary.Add('O', "---");
            dictionary.Add('P', ".--.");
            dictionary.Add('Q', "--.-");
            dictionary.Add('R', ".-.");
            dictionary.Add('S', "...");
            dictionary.Add('T', "-");
            dictionary.Add('U', "..-");
            dictionary.Add('V', "...-");
            dictionary.Add('W', ".--");
            dictionary.Add('X', "-..-");
            dictionary.Add('Y', "-.--");
            dictionary.Add('Z', "--..");

            dictionary.Add('1', ".----");
            dictionary.Add('2', "..---");
            dictionary.Add('3', "...--");
            dictionary.Add('4', "....-");
            dictionary.Add('5', ".....");
            dictionary.Add('6', "-....");
            dictionary.Add('7', "--...");
            dictionary.Add('8', "---..");
            dictionary.Add('9', "----.");
            dictionary.Add('0', "-----");
        }
    }
}
