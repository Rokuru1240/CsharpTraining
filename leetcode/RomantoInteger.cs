public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> Roman = new Dictionary <char,int> {
            ['I']=1,['V']=5,['X']=10,['L']=50,['C']=100,['D']=500,['M']=1000
        };
        int i,slen=s.Length,result=0;
        for(i=0;i<slen;i++)
        {
            if(i+1<slen&&Roman[s[i]]<Roman[s[i+1]])
                result-=Roman[s[i]];
            else
                result+=Roman[s[i]];
        }
        return result;
    }
}