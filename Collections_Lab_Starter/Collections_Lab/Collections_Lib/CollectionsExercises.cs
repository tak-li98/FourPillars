using System;
using System.Collections.Generic;


namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string output="";
            int count = 0;
            if (num > queue.Count)
            {
                num = queue.Count;
            }
            while (count<num)
            {
                    if (count < num - 1)
                    {
                        output += queue.Dequeue() + ", ";
                    }
                    else
                    {
                        output += queue.Dequeue();
                    }
                count++;
            }
            return output;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            var stack = new Stack<int>();
            foreach (var num in original)
            {
                stack.Push(num);
            }
            var reverse = stack.ToArray();
            return reverse;
            
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            string output = "";
            var dict = new Dictionary<char, int>(); 
            foreach (char num in input)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var item in dict)
            {
                if (int.TryParse(item.Key.ToString(), out int IsInt))
                {
                    output += item;
                }
            }
            return output;
        }
    }
}
