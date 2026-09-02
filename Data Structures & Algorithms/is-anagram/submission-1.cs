public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        var dictionary = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            if(!dictionary.ContainsKey(s[i]))
            {
                dictionary[s[i]] = 0;
            }
            dictionary[s[i]]++;

            if (!dictionary.ContainsKey(t[i]))
            {
                dictionary[t[i]] = 0;
            }
            dictionary[t[i]]--;
        }

        foreach (var kv in dictionary)
        {
            if (kv.Value != 0)
            {
                return false;
            }
        }

        return true;

    }
}
