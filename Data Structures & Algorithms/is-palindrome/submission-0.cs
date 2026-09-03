public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder sb = new StringBuilder();
        foreach (char c in s) 
        {
            if (char.IsLetterOrDigit(c)) 
            {
                sb.Append(char.ToLower(c));
            }
        }
        
        string cleaned = sb.ToString();
        Stack<char> stack = new Stack<char>();
        int middle = cleaned.Length / 2;

        for (int i = 0; i < cleaned.Length; i++) 
        {
            if (i < middle) 
            {
                stack.Push(cleaned[i]);
            } 
            else 
            {
                if (cleaned.Length % 2 != 0 && i == middle) {
                    continue;
                }

                if (stack.Pop() != cleaned[i]) 
                {
                    return false;
                }
            }
        }
        return true;
    }
}