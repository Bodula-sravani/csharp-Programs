using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    internal class CipherMessage
    {

        
        public string NicoCipher(string message, string key)
        {
            // Function that takes two arguments, key and message, and returns the encoded message.

            char[] letters = key.ToCharArray();   // Store the string as a char array to sort it
            Array.Sort(letters);
            int[] indexs = new int[key.Length];
            Dictionary<char,int> dict= new();     // To keep track of duplicate chars in key
            for (int iterate = 0; iterate < indexs.Length; iterate++)
            { 
                // Checks if the dict contains the char and updates the value accordingly
                if (!dict.ContainsKey(letters[iterate])) 
                {
                    dict.Add(letters[iterate],0);
                }
                // Get the index of that char in key - startIndex arg: to search for next occurence of that char
                int tempIndex = key.IndexOf(letters[iterate], dict[letters[iterate]]);
                indexs[tempIndex] = iterate;
                dict[letters[iterate]] = tempIndex+1;
            }

            // Store the result message
            string result = "";
            int iterate2 = 0;
            while (iterate2 < message.Length)
            {
                // Char array with ' ' intially
                // Updates the array using ciphered indexes iteratively 
                char[] messageLetters = Enumerable.Repeat(' ', indexs.Length).ToArray();
                foreach (int index in indexs)
                {
                    if (iterate2 < message.Length)
                    {
                        messageLetters[index] = message[iterate2];
                        iterate2++;
                    }
                }
                // Join the ciphered chars into result string
                result += string.Join("", messageLetters);
            }
            return result;
        }

        public static void Main(string[] args)
        {
            CipherMessage msg = new CipherMessage();

            //user defined input
            Console.WriteLine("Enter the message");
            string message = Console.ReadLine().Trim();
            Console.WriteLine("Enter the cipher key");
            string key = Console.ReadLine();
            Console.WriteLine($"ciphered message: {msg.NicoCipher(message,key)}");

            //use cases
            Console.WriteLine($"ciphered message: {msg.NicoCipher("iloveher", "612345")}"); 
        }
    }
}
