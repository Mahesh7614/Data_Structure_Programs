
namespace Data_Structure_Programs
{
    public class SimpleBalancedParentheses
    {
        public void BalancedParentheses(string expression) 
        {
            Stack<char> stack = new Stack<char>();
            foreach (char element in expression)
            {
                if (element.Equals('('))
                {
                    stack.Push(element);
                }
                if (element.Equals(')'))
                {
                    stack.Pop();
                }
            }
            foreach (char element in stack)
            {
                Console.WriteLine("Elements in Stacks is : " +element);
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("Parentheses are Balanced!");
            }
            else
            {
                Console.WriteLine("Parentheses are not Balanced!");
            }
        }
    }
}
