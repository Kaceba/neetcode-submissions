class Solution:
    def reverseString(self, s: List[str]) -> None:
        """
        Do not return anything, modify s in-place instead.
        """

        l = 0
        r = len(s) - 1
        supp = 0

        while l < r:
            supp = s[l]
            s[l] = s[r]
            s[r] = supp
            l += 1
            r -= 1
        