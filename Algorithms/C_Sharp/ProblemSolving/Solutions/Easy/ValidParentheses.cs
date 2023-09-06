using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving.Solutions.Easy
{
    internal class ValidParentheses
    {
        public bool Solution (string s)
        {
            Dictionary<char, char> bracketsMap = new Dictionary<char, char>{
            {'{',  '}'},
            {'(',  ')'},
            {'[',  ']'},
        };
            Stack<char> openBrackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracketsMap.ContainsKey(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0)
                    {
                        return false;
                    }
                    if (bracketsMap[openBrackets.Pop()] == bracket)
                    {
                        continue;
                    };
                    return false;
                }
            }
            return openBrackets.Count == 0;
        }
    }
}
