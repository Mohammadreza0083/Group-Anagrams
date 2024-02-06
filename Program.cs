using System.Text;

namespace Group_Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your strings : ");
            List<string> input = new();
            string condition = "Y";
            while (condition == "Y" || condition == "y")
            {
                input.Add(Console.ReadLine());
                Console.WriteLine("Enter 'Y' if you want add more strings...");
                condition = Console.ReadLine();
            }
            IList<IList<string>> result = GroupAnagrams.GroupAnagram(input.ToArray());
            StringBuilder ResultOutput = new StringBuilder();
            foreach (var group in result)
            {
                ResultOutput.Append("[");
                foreach (var item in group)
                {
                    ResultOutput.Append(item + ", ");
                }
                ResultOutput.Remove(ResultOutput.Length - 2, 2); //remove 2 end character " , ""
                ResultOutput.Append("] ");
            }
            Console.WriteLine($"Your result is {ResultOutput}");
        }
    }
}
