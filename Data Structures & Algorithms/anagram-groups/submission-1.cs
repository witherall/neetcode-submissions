public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var result = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            var count = new int[26];
            foreach(char c in s)
            {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if(!result.TryGetValue(key, out var listOfAnagrams))
            {
                listOfAnagrams = new List<string>();
                result[key] = listOfAnagrams;
            }
            listOfAnagrams.Add(s);
        }

        return result.Values.ToList<List<string>>();
    }
}
