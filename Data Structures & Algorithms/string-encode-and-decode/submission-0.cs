public class Solution {

    public string Encode(IList<string> strs) {

        string endResult = "";
        string currentString = "";

        //cycle all strings
        foreach(var line in strs){
            //concat them
            currentString = line;
            //kinda like http or low level protocols, size, splitter, content
            endResult += line.Length + "#" + currentString;
        }
        //return the concat
        return endResult;
    }

    public List<string> Decode(string s) {

        List<string> result = new();
        if(string.IsNullOrEmpty(s)) return result;

        int i = 0;
        while (i < s.Length)
        {
            // read digits until we hit '#'
            int j = i;
            while (j < s.Length && s[j] != '#')
            {
                j++;
            }

            // parse length
            int len = int.Parse(s.Substring(i, j - i));

            // skip the '#'
            int contentStart = j + 1;

            // take exactly len characters as the next string
            string value = s.Substring(contentStart, len);
            result.Add(value);

            // move i to the position after the extracted string
            i = contentStart + len;
        }

    return result;

   }
}
