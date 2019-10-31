using System;
using System.Collections.Generic;


namespace RemoveDuplicates
{
      class Program
    {
        static void Main(string[] args)
        {

        }

    }
    public class Answer
    {
        public List<int> Elements;
        public Answer(List<int> inputList)
        {
            this.Elements = GetAnswer(inputList);
        }
        
        public List<int> GetAnswer(List<int> inputList)
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
