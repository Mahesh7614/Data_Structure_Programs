using Newtonsoft.Json;

namespace Data_Structure_Programs
{
    public class Node1
    {
        public int data;
        public Node1 next;
        public Node1(int data)
        {
            this.data = data;
        }
    }
    public class OrderedList
    {
        int size = 0;
        private Node1 head;
        private string filepath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Data_Structure_Programs\Data_Structure_Programs\Data\OrderedList.json";
        public void OrderedLinkedList(int num)
        {
            string readnumbers = File.ReadAllText(filepath);
            string fileData = JsonConvert.DeserializeObject<string>(readnumbers);
            string[] myFile = fileData.Split(' ');
            foreach(string line in myFile)
            {
                int element = int.Parse(line);  
                SortedLinkedList(Add(element));
            }
            int a = Search(num);
            if (Search(num) > 0)
            {
                DeleteNodeAtPerticularPosition(Search(num));
            }
            else
            {
                SortedLinkedList(Add(num));
            }
            Display(ref size);
            int[] joinstring = new int [size];
            joinstring[0] = head.data;
            Node1 temp = head;
            for (int i = 1; i < joinstring.Length; i++)
            {
                temp = temp.next;
                joinstring[i] = temp.data;
            }
            string combineWords = string.Join(" ", joinstring);
            string writeText = JsonConvert.SerializeObject(combineWords);
            File.WriteAllText(filepath, writeText);
        }
        private int Add(int data)
        {

            Node1 node = new Node1(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node1 temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            return data;
        }
        public int Search(int value)
        {
            int count = 1;
            Node1 temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        private void DeleteNodeAtPerticularPosition(int position)
        {
            if (head == null)
            {
                return;
            }
            Node1 temp = head;
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
            Node1 next1 = temp.next.next;
            temp.next = next1;
        }
        public void SortedLinkedList(int data)
        {
            Node1 temp = head, index = null;

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
                        if (temp.data > index.data)
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
        private void Display(ref int size )
        {

            int i = 1;
            Node1 temp = head;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"Element {i} in Linked List is : " + temp.data);
                temp = temp.next;
                size++;
                i++;
            }
        }
    }
}

