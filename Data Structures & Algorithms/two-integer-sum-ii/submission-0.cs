public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length-1;

        while(numbers[left] + numbers[right] != target)
        {
            var sum = numbers[left] + numbers[right];

            if(sum < target)
            {
                left++;
            }

            else if(sum > target)
            {
                right--;
            }
        }
        return [left+1, right+1];
    }
}
