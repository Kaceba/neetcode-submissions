public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length == 0){ 
            return 0;
        }

        //sorting wastes time and is not compliant with the O(n) requirement
        HashSet<int> numSet = new HashSet<int>(nums);

        int longest = 0;

       //cycle the nums array once
       foreach (int num in numSet) {
            // If num is the start of a sequence
            if (!numSet.Contains(num - 1)) {
                int current = num;
                int streak = 1;

                // Extend the sequence
                while (numSet.Contains(current + 1)) {
                    current++;
                    streak++;
                }

                // Update the global maximum
                if (streak > longest) longest = streak;
            }
        }
        
        return longest;
    }
}
