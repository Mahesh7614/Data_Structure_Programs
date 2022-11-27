
using System;

namespace Data_Structure_Programs
{
    public class Node2
    {
        public int data;
        public Node2 next;
        public Node2(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        public Node2 head;
        public int Add(int data)
        {

            Node2 node = new Node2(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node2 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            return data;
        }
        public void SortedLinkedList(int data)
        {
            Node2 temp = head, index = null;

            if (head == null)
            {
                return;
            }
            else
            {
                while (temp != null)
                {
                    index = temp.next;

                    while (index != null)
                    {
                        if (temp.data < index.data)
                        {
                            data = temp.data;
                            temp.data = index.data;
                            index.data = data;
                        }
                        index = index.next;
                    }
                    temp = temp.next;
                }
            }
        }
        public void Display()
        {
            Node2 temp = head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
    public class Queue
    {
        Node2 front;
        Node2 rear;

        public void Enqueue(int data)
        {
            Node2 newNode = new Node2(data);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
        }
        public void Display()
        {
            Node2 temp = front;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
    public class PrimeNumber
    {
        LinkedList list = new LinkedList();
        Queue queue = new Queue();
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
                                    list.SortedLinkedList(list.Add(primeNum[i, j]));
                                    queue.Enqueue(primeNum[i, j]);
                                    anagram[i, j] = primeNum[k, q];
                                    list.SortedLinkedList(list.Add(primeNum[k, q]));
                                    queue.Enqueue(primeNum[k, q]);
                                    break;
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine("\n---------------- Display Anagram Prime Numbers Rverese order using stack in Range (1 - 1000) ----------------");
            list.Display();
            Console.WriteLine("\n---------------- Display Anagram Prime Numbers using Queue in Range (1 - 1000) ----------------");
            queue.Display();

        }
        public void PrintNotAnagramNumbers()
        {
            Console.WriteLine("\n---------------- Display Not Anagram Prime Numbers in Range (1 - 1000) ----------------");
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
