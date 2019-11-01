using System;
using System.Collections.Generic;


namespace RemoveDuplicates
{
    public static class Answer
    {
        static void Main(string[] args)
        {

        }
        public static List<int> Deduplicate(List<int> inputList)
        {
            var outputList = new List<int>(){};
            if( inputList.Count == 0)
            {
                return inputList;
            }

            foreach(var l in inputList)
            {
                if( !outputList.Contains(l))
                {
                    outputList.Add(l);
                }
            }
            return outputList;
        }

    }
}
