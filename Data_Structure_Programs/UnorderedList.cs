using Newtonsoft.Json;
using System.Drawing;
using System.Xml.Linq;

namespace Data_Structure_Programs
{
    public class UnorderedList
    {
        private string filePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Data_Structure_Programs\Data_Structure_Programs\JasonData.json";

        public void UnorderedListAddRemove(string word)
        {
            int size = 0;
            bool wordExists = false;
            string readText = File.ReadAllText(filePath);
            string fileData = JsonConvert.DeserializeObject<string>(readText);

            Console.WriteLine(fileData);
            LinkedList<string> list = new LinkedList<string>(fileData.Split(' ').Select(n => (n.Trim())));

            foreach (string Words in list)
            {
                if (Words == word)
                {
                    wordExists = true;
                    Console.WriteLine($"{word} is exists  in List so it will be Removed from List");
                    list.Remove(Words);
                    Console.WriteLine($"{word} Removed Sucessfully from List");
                    break;
                }
            }
            if (!wordExists)
            {
                Console.WriteLine($"{word} is not exists in List so it will be Addeed to list");
                list.AddLast(word);
                Console.WriteLine($"{word} is successfully Added in the List");
            }

            string combineWords = string.Join(" ", list);
            string writeText = JsonConvert.SerializeObject(combineWords);
            File.WriteAllText(filePath, writeText);
        }
    }
}
