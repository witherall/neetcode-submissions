public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        var numSet = new HashSet<int>(nums);

        int longest = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int length = 0;
                while(numSet.Contains(num + length))
                {
                    length++;
                }
                if(length > longest)
                {
                    longest = length;
                }
            }
        }

        return longest;
    }
}