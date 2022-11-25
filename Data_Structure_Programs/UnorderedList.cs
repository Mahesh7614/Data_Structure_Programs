using Newtonsoft.Json;

namespace Data_Structure_Programs
{
    public class Node
    {
        public string data;
        public Node next;
        public Node(string data)
        {
            this.data = data;
        }
    }
    public class UnorderedList
    {
        public Node head;
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Data_Structure_Programs\Data_Structure_Programs\Data\UnorderedList.json";
        public void UnorderedListAddRemove(string word)
        {
            string readText = File.ReadAllText(filePath);
            string fileData = JsonConvert.DeserializeObject<string>(readText);

            Console.WriteLine($"The Sentence is : \n{fileData}");
            string[] wordsArray = fileData.Split(' ');

            foreach (string item in wordsArray)
            {
                Add(item);
            }
            if (Search(word) > 0)
            {
                DeleteNodeAtPerticularPosition(Search(word));
            }
            else
            {
                Add(word);
            }
            string[] joinstring = new string[Size()];

            joinstring[0] = head.data;
            Node temp = head;
            for (int i = 1; i < joinstring.Length; i++)
            {
                temp = temp.next;
                joinstring[i] = temp.data;
            }
            string combineWords = string.Join(" ", joinstring);
            string writeText = JsonConvert.SerializeObject(combineWords);
            File.WriteAllText(filePath, writeText);
            Console.WriteLine($"\nThe updated Sentence is : \n{combineWords}");
        }
        private void Add(string data)
        {

            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        private void DeleteNodeAtPerticularPosition(int position)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 1)
            {
                head = temp.next;
                return;
            }
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next1 = temp.next.next;
            temp.next = next1;
        }
        private int Search(string value)
        {
            int Count = 1;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data.Equals(value))
                {
                    return Count;
                }
                temp = temp.next;
                Count++;
            }
            return 0;
        }
        private int Size()
        {
            int size = 0;
            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            return size;
        }
    }
}
