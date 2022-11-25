using System;

namespace Data_Structure_Programs
{
    public class UserInput
    {
        public void UserInputForPrograms()
        {
            Console.WriteLine("Enter - 1. Unordered List ");
            Console.WriteLine("Enter - 2. Ordered List ");

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
            }
        }
    }
}
