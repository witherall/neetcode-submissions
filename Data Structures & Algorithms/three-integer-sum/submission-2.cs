public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        for(int i=0; i<nums.Length-1;i++)
        {
            if(i>0 && nums[i]==nums[i-1])
            {
                continue;
            }
            int l = i+1;
            int r=nums.Length-1;
            while(l<r)
            {
                var threeSum = nums[i] + nums[l] + nums[r];
                if(threeSum < 0)
                {
                    l++;
                }
                else if(threeSum > 0)
                {
                    r--;
                }
                else
                {
                    result.Add([nums[i], nums[l], nums[r]]);
                    l++;
                    while(nums[l] == nums[l-1] && l<r)
                    {
                        l++;
                    }
                }
            }
        }
        return result;
    }
}
