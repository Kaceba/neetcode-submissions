public class Solution {
    public bool IsValid(string s) {

        // ( ) { } [ ]

        //brute force first
        List<char> stack = new();
        //cycle the string, for every char of the string add to the List if its an open
        foreach (char c in s.ToCharArray()) {
            if(c == '(' || c == '[' || c == '{'){
                stack.Add(c);
            }
             //else if its a closed remove the preceding open from the stack
            else if(c == ')'|| c == ']'|| c == '}'){
                if (stack.Count == 0) return false;
                char last = stack[stack.Count - 1];
                if ((c == ')' && last == '(') || (c == ']' && last == '[') || (c == '}' && last == '{')) {
                    stack.RemoveAt(stack.Count - 1);
                } else {
                    return false;
                }
            }
         } 

        //if at the end the string has no characters in it then its true else its false
        if (stack is null or [])
        {            // List is either null or has zero elements
            return true;
        }

        return false;
    }
}
