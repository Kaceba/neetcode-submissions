class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        hs = set()

        for n in nums:
            if n not in hs:
                hs.add(n)
            else:
                 return True

        return False
    
