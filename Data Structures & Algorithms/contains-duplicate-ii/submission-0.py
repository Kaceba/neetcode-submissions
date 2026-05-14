class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        hm = {}
        for idx, num in enumerate(nums):
            if num in hm:
                if abs(hm[num] - idx) <= k:
                    return True
            hm[num] = idx
        return False
                
