using System;
using System.Collections.Generic;


namespace RemoveDuplicates
{
    public static class Program
    {
        static void Main(string[] args)
        {

        }
        public static class Answer<T>
        {
            public static List<T> Deduplicate(List<T> inputList)
            {
                var outputList = new List<T>() { };
                if (inputList.Count == 0)
                {
                    return inputList;
                }

                foreach (var l in inputList)
                {
                    if (!outputList.Contains(l))
                    {
                        outputList.Add(l);
                    }
                }
                return outputList;
            }
        }

    }
}
