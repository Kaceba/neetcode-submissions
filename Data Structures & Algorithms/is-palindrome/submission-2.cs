public class Solution {
    public bool IsPalindrome(string s) {

        int i = 0;
        int k = s.Length - 1;
        while (i < k){
            //i needs to cycle from index 0 to max Lenght
            //k needs to cycle from max lenght to 0
            //if they both match then its a palindrome

            while(i < k  &&  !char.IsLetterOrDigit(s[i])){
                i++;
            }
            while(i < k  &&  !char.IsLetterOrDigit(s[k])){
                k--;
            }

            if(char.ToLower(s[i]) != char .ToLower(s[k])){
                return false;
            }

            i++;
            k--;
        }   

        return true;

    }
}
