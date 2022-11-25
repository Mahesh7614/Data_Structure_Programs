
namespace Data_Structure_Programs
{
    public class SimulateBankingCashCounter
    {
        int bankBalance = 500000;
        public void CashCounter(int people)
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < people; i++)
            {
                queue.Enqueue(i);
                Banking();
                queue.Dequeue();
                if (bankBalance == 0)
                {
                    Console.WriteLine("Bank Balance is Empty");
                }
            }
            if(queue.Count == 0)
            {
                Console.WriteLine("Cash Counter Queue is Cleared");
            }
            else
            {
                Console.WriteLine("\nPeoples are remaining in Queue Cash counter is Closed!");
            }
            Console.Write("\nCurrent Bank Balance is : " + bankBalance);

        }
        public void Banking() 
        {
            Console.WriteLine("Enter 1. Withdraw cash\n" +
                "Enter 2. Deposite Cash");
            int choice = Convert.ToInt32(Console.ReadLine());
            int account = 0;
            switch(choice)
            {
                case 1:
                    Console.Write("Enter amount to Withdraw : ");
                    account= Convert.ToInt32(Console.ReadLine());
                    bankBalance -= account;
                    break;

                case 2:
                    Console.Write("Enter amount to Deposite : ");
                    account = Convert.ToInt32(Console.ReadLine());
                    bankBalance -= account;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
