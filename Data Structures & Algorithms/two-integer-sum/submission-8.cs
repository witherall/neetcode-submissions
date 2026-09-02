public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        var dict = new Dictionary<int,int>();
        for (int i=0; i< nums.Length; i++)
        {
            var numberToLookFor = target - nums[i];
            if(dict.TryGetValue(numberToLookFor, out var index))
            {
                return new int[]{index, i};
            }

            dict[nums[i]] = i;
        }

        return new int[2];
    }
}
