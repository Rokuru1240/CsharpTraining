public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = strs[0];
        for(int i = 1;i<strs.Length;i++)
        {
            while(strs[i].IndexOf(prefix)!=0)
            {
                prefix = prefix.Substring(0,prefix.Length-1);
                if(prefix == string.Empty)
                    return "";
            }
        }
        return prefix;
    }
}