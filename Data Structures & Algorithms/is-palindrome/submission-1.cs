public class Solution {
    public bool IsPalindrome(string s) {

        char[] buffer = s.ToCharArray();
        bool palindrome = true;

        int i = 0;
        int k = buffer.Length - 1;
        while (i < k){
            //i needs to cycle from index 0 to max Lenght
            //k needs to cycle from max lenght to 0
            //if they both match then its a palindrome

            while(i < k  &&  !Char.IsLetterOrDigit(buffer[i])){
                i++;
            }
            while(i < k  &&  !Char.IsLetterOrDigit(buffer[k])){
                k--;
            }

            Console.WriteLine(buffer[i] + " " + buffer[k]);

            if(Char.ToLower(buffer[i]) != Char .ToLower(buffer[k])){
                return false;
            }
            
            i++;
            k--;
        }   

        return palindrome;

    }
}
