public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        var hash = new Dictionary<char,int>();

        foreach(char c in s)
        {
            if(!hash.ContainsKey(c))
            {
                hash[c] = 1;
            }
            else
            {
                hash[c]++;
            }
        }

        foreach(char c in t)
        {
            if(!hash.ContainsKey(c))
            {
                return false;
            }
            hash[c]--;

            if(hash[c] < 0)
            {
                return false;
            }
        }


        return hash.Values.All(v => v == 0);
    }
}
