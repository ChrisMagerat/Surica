using System;

namespace TurnWheel
{
    class Wheel
    {
        /* This function determines the distance between the current and
         * previous letter. The distance is caclulated by taking the
         * relative dictionary index of the current letter and subtracting
         * that form the relative dictionary index of the previous letter. 
         * The absolute of this is taken to ensure that the distance is
         * always positive. For example moving from c to d will implement:
         * |c - d| = |2 - 3| = |-1| = 1
         * 
         * To compensate for the shortest path a condition is tested for when
         * the index value is greater than 13 this means that a shorter distance 
         * will be achieved by moving backwards instead of forward. If this is 
         * the case subtract the distance from 26 and this will ensure a backwards 
         * movement
         * 
         * parampaters: char letter - letter moving towards
         *              char previousLetter - letter moving from
         * returns: The time value baced on the distance between 2 letters. This
         *          is the distance times 5 seconds to achieve time. Of type double. 
         *          
         * 
         */
        static double getLetterTime(char letter,char previousLetter)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int indexChar = alphabet.IndexOf(letter);
            int indexPreviousLetter = alphabet.IndexOf(previousLetter);
            int distance = Math.Abs(indexChar - indexPreviousLetter);
            if (distance > 13)
            {
                distance = 26 - distance;
            }
            return distance*5;
        }




        /* This function determines the total time of the sequence.
         * Conditional tests are implemented when the first letter is 'a' 
         * when a letter is repeated. In both the time value is 2.5 seconds
         * 
         * parampaters: string sentence - input sequence
         * returns: The total time as type double
         * 
         */
        static double getTime(string sentence)
        {
            double total = 0;
            char previous = 'a';
            for (int i = 0; i < sentence.Length; i++)
            {
                char c = sentence[i];
                if (c == previous)
                {
                    total += 2.5;
                    previous = c;
                    continue;
                }
                else
                {
                    if ((i == 0) && (c == 'a'))
                    {
                        total += 2.5;
                    }
                    else
                    {
                        total += getLetterTime(c, previous);
                        previous = c;
                    }
                }
                
            }
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence");
            string input = "";
            input = Console.ReadLine().ToLower();
            double totaltime = getTime(input);
            Console.WriteLine(totaltime + " seconds");
        }
    }
}