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
            }
        }
    }
}
