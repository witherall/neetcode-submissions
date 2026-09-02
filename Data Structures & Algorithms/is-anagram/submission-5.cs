public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var charArray = new int[26];

        for(int i=0; i<s.Length; i++)
        {
            charArray[s[i] - 'a']++;
            charArray[t[i] - 'a']--;
        }
        foreach(int num in charArray)
        {
            if (num != 0)
            {
                return false;
            }
        }
        
        return true;
    }
}
