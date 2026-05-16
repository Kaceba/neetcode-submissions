class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:

        hset = set()
        count = 0
        maxSub = 0

        L = 0
        R = 0

        while R < len(s):
            while s[R] in hset:
                hset.remove(s[L])
                L += 1
            
            hset.add(s[R])
            count = R - L + 1
            maxSub = max(maxSub, count)
            R += 1

        return maxSub
        
