class Solution:
    def maxArea(self, heights: List[int]) -> int:
        #you have to consider the two highest heights[i] values and 
        #how distant are they in the array from one another
        #because 7 and 6 are the highest in the example, and they are 6 indices apart
        #so the area of the section is 6 x 6 = 36

        #int
        indexFirst = 0
        indexSecond = len(heights) - 1
        maxArea = 0

        #you have to constantly calculate the area to find the answer
        while indexFirst < indexSecond: 
            current_area = min(heights[indexFirst], heights[indexSecond]) * (indexSecond - indexFirst)
            if current_area > maxArea:
                maxArea = current_area
            
            if heights[indexFirst] < heights[indexSecond]:
                indexFirst += 1
            else:
                indexSecond -=  1

       
        return maxArea

            
