
namespace Data_Structure_Programs
{
    public class PrimeNumber
    {
        public void PrimeChecker()
        {
            int start = 0, end = 1000;
            int range = 0, index = 0, change = 0;

            int[,] primeNumbers = new int[10, 100];
            Console.WriteLine("\n---------------- Printing Prime Number in Range ({0} - {1}) ----------------", start, end);
            for (int i = start + 1; i <= end; i++)
            {
                if (i > 100)
                {
                    string temp = Convert.ToString(i);
                    char ind = temp[0];
                    range = Convert.ToInt32(ind) - 48;

                }
                if (change != range)
                {
                    index = 0;
                    change = range;
                }
                int flag = 0;
                for (int j = start; j < i; j++)
                {
                    if (i != 0 && i != 1 && j != 0 && j != 1 && (i % 2 == 0 || i % j == 0))
                    {
                        flag = 1;
                        break;
                    }
                }
                if (i != 1 && (flag != 1 || i == 2))
                {
                    primeNumbers[range, index] = i;
                    index++;
                }
            }
            int a = 0, b = 100;
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (primeNumbers[k, l] != 0)
                    {
                            Console.WriteLine(primeNumbers[k, l]);
                        
                    }
                }

                Console.WriteLine($"******************** Prime Numbers from {a} to {b} ********************");
                a= 0;
                 a= a+b;
                b= b+100;
            }

        }
    }
}
