using Newtonsoft.Json;
using System.Collections;

namespace Data_Structure_Programs
{
    public class HashTableData
    {
        private string filepath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Data_Structure_Programs\Data_Structure_Programs\Data\HashData.json";
        Hashtable hashtable = new Hashtable();
        public void HashData(string searchValue)
        {
            bool dataExists = false;
            string readnumbers = File.ReadAllText(filepath);
            string fileData = JsonConvert.DeserializeObject<string>(readnumbers);
            string[] numbers = fileData.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                hashtable.Add(i, numbers[i]);
            }
            Console.WriteLine("************************* Hash Table Elements *************************");
            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("{0}: {1}", key, hashtable[key]);
            }
            foreach (int key in hashtable.Keys)
            {
                if (hashtable[key].Equals(searchValue))
                {
                    dataExists = true;
                    hashtable.Remove(key);
                    break;
                }
            }
            if (!dataExists)
            {
                int insertKey = hashtable.Count + 1;
                hashtable.Add(insertKey, searchValue);
            }

            string[] joinstring = new string[hashtable.Count];
            int j = 0;
            foreach (int key in hashtable.Keys)
            {
                string result = Convert.ToString(hashtable[key]);
                joinstring[j] = result;
                j++;

            }
            string combineNumbers = string.Join(" ", joinstring);
            string writeNumbers = JsonConvert.SerializeObject(combineNumbers);
            File.WriteAllText(filepath, writeNumbers);
        }
        public void DisplayHashTable()
        {
            Console.WriteLine("************************* Updated Hash Table Elements *************************");

            foreach (var key in hashtable.Keys)
            {
                Console.WriteLine("{0}: {1}", key, hashtable[key]);
            }
        }
    }
}
