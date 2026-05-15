class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:

        maxSeq = 0
        latestAdded = 0
        hset = set(nums)

        for num in hset:
            if num - 1 not in hset:
                lenght = 1
                while num + lenght in hset:
                    lenght += 1
                maxSeq = max(lenght, maxSeq)

        return maxSeq



            

