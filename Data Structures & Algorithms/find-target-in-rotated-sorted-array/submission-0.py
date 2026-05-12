class Solution:
    def search(self, nums: List[int], target: int) -> int:
        
        #start from the middle, go for i - 1 until nums[i - 1] != n - 1, that way we can divide the array in 2
        left = 0;
        right = len(nums) -1

        while left <= right:
            mid = (left + right) // 2

            if(nums[mid] == target):
                return mid

            #left side is sorted
            if nums[left] <= nums [mid]:
                if nums[left] <= target < nums[mid]:
                    right = mid - 1 
                else:
                    left = mid + 1
            else:
                #right side is sorted
                if nums[mid] < target <= nums[right]:
                    left = mid + 1
                else:
                    right = mid - 1
                

        return -1
        
        