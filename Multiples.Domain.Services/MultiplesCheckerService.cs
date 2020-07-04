using System;
using System.Collections.Generic;
using Multiples.Domain.Entities;

namespace Multiples.Domain.Services
{
    public class MultiplesCheckerService
    {
        public List<NumberResult> CheckMultiples(List<string> numbersToTest)
        {
            var resultList = new List<NumberResult>();

            numbersToTest.ForEach(number => {
                resultList.Add(new NumberResult(number, IsMultiple(number)));
            });

            return resultList;
        }

        private bool IsMultiple(string number)
        {
            var oddsSum = GetSumOfAlternateNumbers(number, 0);
            var evensSum = GetSumOfAlternateNumbers(number, 1);

            return oddsSum == evensSum;
        }

        private int GetSumOfAlternateNumbers(string expression, int startIndex)
        {
            var result = 0;

            for (int i = startIndex; i < expression.Length; i = i + 2)
            {
                result += Convert.ToInt32(expression[i].ToString());
            }

            return result;
        }
    }
}
