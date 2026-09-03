public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var numbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var remainder = target - nums[i];

            if(numbers.TryGetValue(remainder, out int j))
            {
                return [j, i];
            }

            numbers[nums[i]] = i;
        }

        return [];
    }
}
