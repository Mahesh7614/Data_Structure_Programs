using System;

namespace Data_Structure_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Unordered List ");
            Console.WriteLine("Enter - 2. Ordered List ");
            Console.WriteLine("Enter - 3. Simple Balanced Parentheses");
            Console.WriteLine("Enter - 4. Simulate Banking Cash Counter");
            Console.WriteLine("Enter - 5. Palindrome Checker");
            Console.WriteLine("Enter - 6. Hash Table");
            Console.WriteLine("Enter - 7. No of Binary search Tress");
            Console.WriteLine("Enter - 8. Prime Numbers 1-1000");
            Console.WriteLine("Enter - 9. Calender");


            Console.Write("\nEnter Selected Number : ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.Write("Enter Word to Search : ");
                    string word = Console.ReadLine();
                    UnorderedList unordered = new UnorderedList();
                    unordered.UnorderedListAddRemove(word);
                    break;

                case 2:
                    Console.Write("Enter Word to Search : ");
                    int number = Convert.ToInt32(Console.ReadLine());
                    OrderedList ordered = new OrderedList();
                    ordered.OrderedLinkedList(number);
                    break;

                case 3:
                    Console.Write("Enter the Expression : ");
                    string expression = Console.ReadLine();
                    SimpleBalancedParentheses parentheses= new SimpleBalancedParentheses();
                    parentheses.BalancedParentheses(expression);
                    break;

                case 4:
                    Console.Write("Enter the Number of People in Queue : ");
                    int people = Convert.ToInt32(Console.ReadLine());
                    SimulateBankingCashCounter counter = new SimulateBankingCashCounter();
                    counter.CashCounter(people);
                    break;

                case 5:
                    Console.Write("Enter word to check Palindrome or Not : ");
                    string palindrome = Console.ReadLine();
                    PalindromeChecker checker = new PalindromeChecker();
                    checker.CheckPalindrome(palindrome);
                    break;

                case 6:
                    HashTableData hashTable = new HashTableData();
                    Console.WriteLine("Enter the number to search:");
                    string searchValue = Console.ReadLine();
                    hashTable.HashData(searchValue);
                    hashTable.DisplayHashTable();
                    break;

                case 7:
                    Console.Write("Enter No of elements in BST : ");
                    int noOfTress = Convert.ToInt32(Console.ReadLine());
                    NoOfBST bST = new NoOfBST();
                    Console.Write("No of tress to be formed are : " + bST.NumberOfTree(noOfTress));
                    break;

                case 8:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeRange();
                    prime.PrintPrimeNumbers();
                    prime.PrintAnagramNumbers();
                    prime.PrintNotAnagramNumbers();
                    break;

                case 9:
                    Console.Write("Enter the year : ");
                    int year = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the month in Numbers : ");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Calenders calender = new Calenders();
                    calender.GetCalendar(year, month);
                    calender.PrintCalendar(year, month);
                    Console.WriteLine("\n***************************** Display calendar using queue *****************************");
                    calender.DisplayCalendarUsingQueue(year, month);
                    calender.StackImplementation(year, month);
                    break;
            }
        }
    }
}
