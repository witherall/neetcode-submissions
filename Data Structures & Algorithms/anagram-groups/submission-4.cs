public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var dict = new Dictionary<string, List<string>>();
        foreach(string str in strs)
        {
            var sortedChars = str.ToCharArray();
            Array.Sort(sortedChars);
            string sorted = new string(sortedChars);
            if(!dict.TryGetValue(sorted, out var list))
            {
                list = new List<string>();
                list.Add(str);
                dict[sorted] = list;
                continue;
            }

            list.Add(str);
        }

        return dict.Values.ToList();

    }
}