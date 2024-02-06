namespace Group_Anagrams
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> GroupAnagram(string[] input)
        {
            if(input==null || input.Length == 0)
            {
                return new List<IList<string>>();
            }
            Dictionary<string, List<string>> map = new();
            foreach (string item in input)
            {
                char[] InputChars = item.ToCharArray();
                Array.Sort(InputChars);
                string keyStr = new string(InputChars);
                if (!map.ContainsKey(keyStr))
                {
                    map[keyStr] = new List<string>();
                }
                map[keyStr].Add(item);
            }
            return new List<IList<string>>(map.Values);
        }
    }
}
