
namespace Data_Structure_Programs
{
    public class PrimeNumber
    {
        public int[,] primeNum = new int[10, 100];
        public void PrimeRange()
        {
            int num = 2;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    if (IsPrime(num))
                    {
                        primeNum[i, j] = num;
                    }
                    num++;
                }
            }
        }
        public void Print()
        {
            int startRange = 1, endRange = 100; ;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"******************** Prime Numbers from {startRange} to {endRange} ********************");
                for (int j = 0; j < 100; j++)
                {
                    if (primeNum[i, j] != 0)
                    {
                        Console.WriteLine(primeNum[i, j]);
                    }
                }
                startRange = 0;
                startRange = startRange + endRange;
                endRange = endRange + 100;
            }
        }
        public bool IsPrime(int i)
        {
            int j, flag;
            bool findPrime = false;

            if (i == 1 || i == 0)
                findPrime = false;

            flag = 1;

            for (j = 2; j <= i / 2; ++j)
            {
                if (i % j == 0)
                {
                    flag = 0;
                    break;
                }
            }
            if (flag == 1)
            {
                findPrime = true;
            }
            return findPrime;
        }
    }
}
