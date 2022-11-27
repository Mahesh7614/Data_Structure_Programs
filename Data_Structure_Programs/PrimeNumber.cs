
using System;

namespace Data_Structure_Programs
{
    public class PrimeNumber
    {
        public int[,] primeNum = new int[10, 100];
        int[,] anagram = new int[10, 100];
        public int[,] notAnagramNumbers = new int[10, 100];
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
        public void PrintPrimeNumbers()
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
        public void PrintAnagramNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (primeNum[i, j] != 0 && primeNum[i, j] > 10)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int q = j + 1; q < 100; q++)
                            {
                                if (CheckAnagram(primeNum[i, j], primeNum[k, q]))
                                {
                                    anagram[k, q] = primeNum[i, j];
                                    anagram[i, j] = primeNum[k, q];
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n---------------- Printing Anagram Prime Numbers in Range (10 - 1000) ----------------");
            for (int k = 0; k < 10; k++)
            {
                for (int l = 0; l < 100; l++)
                {
                    if (anagram[k, l] != 0)
                    {
                        Console.WriteLine(anagram[k, l]);
                    }

                }
            }
        }
        public void PrintNotAnagramNumbers()
        {
            Console.WriteLine("\n---------------- Printing Not Anagram Prime Numbers in Range (1 - 1000) ----------------");
            int check = 0; 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (primeNum[i, j] != 0)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            for (int q = j + 1; q < 100; q++)
                            {
                                if (primeNum[i, j] == anagram[k, q])
                                {
                                    check = 1;
                                    break;
                                }
                            }
                            if (check == 1)
                            {
                                break;
                            }
                        }
                        if (check == 0)
                        {
                            notAnagramNumbers[i, j] = primeNum[i, j];
                            Console.WriteLine(notAnagramNumbers[i, j]);
                        }
                    }
                }
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
        public bool CheckAnagram(int num1, int num2)
        {
            char[] char1 = Convert.ToString(num1).ToCharArray();
            char[] char2 = Convert.ToString(num2).ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
            string s1 = new string(char1);
            string s2 = new string(char2);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Equals(s2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
