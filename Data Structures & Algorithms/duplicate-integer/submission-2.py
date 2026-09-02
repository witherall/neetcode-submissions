class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        if  len(nums) < 2:
            return False;
        num_count = {}
        for num in nums:
            if num in num_count:
                return True  # Duplicate found
            num_count[num] = 1
        return False