using System;
using System.Linq;
/*To find the frequency of each character in an inputed string. 
 */
namespace Linq_CharacterAndTheirFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the string : ");
            var input = Console.ReadLine();

            var CharacFreq = from x in input
                             group x by x into y
                             select y;

            foreach (var character in CharacFreq)
            {
                Console.WriteLine("The frequency of {0} in the {1} is {2} ",character.Key, input, character.Count()) ;
            }

        }
    }
}
