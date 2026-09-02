public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i=nums.Length-1; i>=0; i--)
        {
            var firstNumber = nums[i];
            var indexOfCompliment = Array.IndexOf(nums, target - firstNumber);

            if (indexOfCompliment != -1)
            {
                return new int[]{indexOfCompliment, i};
            }
        }

        return new int[]{
            0,0
        };
    }
}
