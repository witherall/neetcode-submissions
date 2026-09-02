public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var result = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
            var sArray = s.ToCharArray();
            Array.Sort(sArray);
            var sortedS = new string(sArray);
            if(!result.TryGetValue(sortedS, out var listOfAnagrams))
            {
                listOfAnagrams = new List<string>();
                result[sortedS] = listOfAnagrams;
            }
            listOfAnagrams.Add(s);
        }

        return result.Values.ToList<List<string>>();
    }
}
