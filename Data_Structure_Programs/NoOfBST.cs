
namespace Data_Structure_Programs
{
    public class NoOfBST
    {
        public int NumberOfTree(int noOfElements)
        {
            if (noOfElements <= 1) return 1;

            int sum = 0;
            int left = 0, right = 0;

            for (int i = 1; i <= noOfElements; i++)
            {
                left = NumberOfTree(i - 1);
                right = NumberOfTree(noOfElements - i);
                sum += (left * right);
            }
            return sum;
        }
    }
}
