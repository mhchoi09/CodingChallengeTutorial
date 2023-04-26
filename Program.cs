
using System.Collections;

int[] arrayToBeEvaluated = { 9, 3, 9, 3, 9, 7, 10 };

var duplicates = arrayToBeEvaluated.GroupBy(x => x).Where(y => y.Count() > 1).Select(x => x.Key).ToList();
var unique = new List<int>();
var oddNumbers = new List<int>();

foreach(var value in arrayToBeEvaluated)
{
    if (!duplicates.Contains(value))
    {
        unique.Add(value);
    }
}

foreach(var values in unique)
{
    if(values % 2 != 0)
    {
        oddNumbers.Add(values);
    }
}

var answer = oddNumbers.ToArray();

