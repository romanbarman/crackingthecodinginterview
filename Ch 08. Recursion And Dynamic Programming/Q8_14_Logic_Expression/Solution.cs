using Contracts;
using System;
using System.Collections.Generic;

namespace Chapter08.LogicExpression
{
    public class Solution : ISolution
    {
        private string expression;
        private bool result;

        public Solution(string expression, bool result)
        {
            this.expression = expression;
            this.result = result;
        }

        public bool HasComment => false;

        public string GetComment()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine($"{expression} -> {result}");
            Console.WriteLine($"Result: {CountEval(expression, result, new Dictionary<string, int>())}");
        }

        private int CountEval(string s, bool result, Dictionary<string, int> memo)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                return ConvertToBool(s) == result ? 1 : 0;
            }

            if (memo.ContainsKey(result + s))
            {
                return memo[result + s];
            }

            int ways = 0;

            for (int i = 1; i < s.Length; i++)
            {
                var c = s[i];
                var left = s.Substring(0, i);
                var right = s.Substring(i + 1, s.Length - (i +1));

                var leftTrue = CountEval(left, true, memo);
                var leftFalse = CountEval(left, false, memo);
                var rightTrue = CountEval(right, true, memo);
                var rightFalse = CountEval(right, false, memo);

                var total = (leftTrue + leftFalse) * (rightTrue + rightFalse);

                var totalTrue = 0;

                if (c == '^')
                {
                    totalTrue = leftTrue * rightFalse + leftFalse * rightTrue;
                }
                else if (c == '&')
                {
                    totalTrue = leftTrue * rightTrue;
                }
                else if (c == '|')
                {
                    totalTrue = leftTrue * rightTrue + leftFalse * rightTrue + leftTrue * rightFalse;
                }

                var subWays = result ? totalTrue : total - totalTrue;
                ways += subWays;
            }

            memo[result + s] = ways;

            return ways;
        }

        private static bool ConvertToBool(string s)
        {
            return s == "1";
        }
    }
}
