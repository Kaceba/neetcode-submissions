public class Solution {
    public int LongestConsecutive(int[] nums) {

        Array.Sort(nums);

        if(nums.Length == 0){ 
            return 0;
        }

        //we are assuming the minimum amount of consecutives will always be 1
        //skipping address 0 since its already being used as base after the sort
        int longest = 1;
        int consecutive = 1;

       for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1] + 1) {
                consecutive++;
            } else if (nums[i] != nums[i - 1]) {  // skip duplicates or jumps
                consecutive = 1;
            }
            longest = Math.Max(longest, consecutive);
        }

        return longest;
    }
}
