public class Solution {
    public int Search(int[] nums, int target) {

        //binary search, start from the middle, then compare by doubles
        //its never said if the range of numbers starts at 0
        //so first of all we have to check if the target could be contained in the array by checking max and minimum

        //if max number is smaller than target then -1
        //if min number is bigger than target then -1
        if(nums[nums.Length - 1] < target || nums[0] > target){
            return -1;
        }

        //now we can check if its contained
        int minInx = 0;
        int maxInx = nums.Length - 1;

        while(minInx <= maxInx){

            int mid = minInx + (maxInx - minInx) / 2;
            
            if(nums[mid] == target){
                return mid;
            }

            if(target > nums[mid]){
                minInx = mid + 1;
            }
            else if(target < nums[mid]){
                maxInx = mid - 1;
            }
        }

        return -1;
    }
}
