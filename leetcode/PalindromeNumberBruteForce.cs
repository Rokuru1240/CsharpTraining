public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        string judge = Convert.ToString(x);
                int i,n = judge.Length;
        for(i=0;i<n;i++)
        {
            if(judge[i]!=judge[n-1-i])
                return false;
        }
        return true;
    }
}