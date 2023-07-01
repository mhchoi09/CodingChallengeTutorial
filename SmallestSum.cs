namespace CodingChallengeTutorial
{
    public class SmallestSum
    {
        public int getSumDigit(int i)
        {
            int sumOfDigit = 0;
            for (sumOfDigit = 0; i > 0; i /= 10)
            {
                sumOfDigit += i % 10;
            }
            return sumOfDigit;
        }

        public int solution(int n)
        {
            bool nonMatch = true;
            int x = 0;

            while (nonMatch)
            {
                int sumOfDigits = getSumDigit(x);
                if (n == sumOfDigits)
                {
                    break;
                }
                x += 1;
            }
            return x;
        }
    }
}
