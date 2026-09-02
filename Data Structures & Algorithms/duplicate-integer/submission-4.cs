public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dict = new Dictionary<int,int>();
        foreach(int num in nums)
        {
            if (dict.ContainsKey(num))
            {
                return true;
            }

            dict[num] = 1;
        }

        return false;
    }
}