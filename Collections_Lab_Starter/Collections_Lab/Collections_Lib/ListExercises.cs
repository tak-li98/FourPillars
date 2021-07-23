﻿using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var numList = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    numList.Add(i);
                }
            }
            return numList;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var stringList = new List<string>();
            foreach (var str in sourceList)
            {
                if (str.StartsWith('A')||str.StartsWith('a'))
                {
                    stringList.Add(str);
                }
            }
            return stringList;
        }
    }
}
