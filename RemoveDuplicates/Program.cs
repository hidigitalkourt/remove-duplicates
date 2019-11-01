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
            public static List<T> Deduplicate(List<T> inputValues)
            {
                var outputList = new List<T>() { };
                if (inputValues.Count == 0)
                {
                    return inputValues;
                }

                foreach (var l in inputValues)
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
