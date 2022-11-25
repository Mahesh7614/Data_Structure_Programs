
namespace Data_Structure_Programs
{
    public class PalindromeChecker
    {
        public void CheckPalindrome(string palindrome)
        {
            Queue<char> queue = new Queue<char>();
            for (int i = palindrome.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(palindrome[i]);
            }
            string reverseWord = "";
            while (queue.Count != 0)
            {
                reverseWord = reverseWord + queue.Dequeue();
            }
            if (palindrome.Equals(reverseWord))
            {
                Console.WriteLine("{0} is a Palindrome", palindrome);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome", palindrome);
            }
        }
    }
}
