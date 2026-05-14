class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """

        l = 0
        r = len(s) - 1


        suppl = 0
        suppr = 0
        while l < r:
            suppl = s[l]
            suppr = s[r]
            s[l] = suppr
            s[r] = suppl
            l += 1
            r -= 1
        