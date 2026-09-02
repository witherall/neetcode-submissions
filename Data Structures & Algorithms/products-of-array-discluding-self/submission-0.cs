public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        	var result = new int[nums.Length];
	result[0] = 1;
	for (int i = 1; i < nums.Length; i++)
	{
		result[i] = result[i-1] * nums[i-1];
	}
	int postFix = nums[nums.Length-1];
	for (int i = nums.Length-2; i>=0; i--)
	{
		result[i] = result[i] * postFix;
		postFix = postFix * nums[i];
	}
	
	return result;
    }
}
