using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallengeTutorial
{
    public class OddOccurenceInArray
    {
        /*A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the 
         * array can be paired with another element that has the same value, except for one element that is left unpaired.*/

        public static dynamic LessonTwoSolution(int[] arrayToBeEvaluated)
        { 

            var duplicates = arrayToBeEvaluated.GroupBy(x => x).Where(y => y.Count() > 1).Select(x => x.Key).ToList();
            var unique = new List<int>();
            var oddNumbers = new List<int>();

            foreach (var value in arrayToBeEvaluated)
            {
                if (!duplicates.Contains(value))
                {
                    unique.Add(value);
                }
            }

            foreach (var values in unique)
            {
                if (values % 2 != 0)
                {
                    oddNumbers.Add(values);
                }
            }

            var answer = oddNumbers.ToList();

            return answer;
        }
    }
}
