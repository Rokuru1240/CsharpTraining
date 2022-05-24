public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer = new int[2];
        int n = nums.Length;
        int i,o;
        for(i=0;i<n;i++)
        {
            for(o=i+1;o<n;o++)
            {
                if(nums[i]+nums[o]==target)
                {
                    answer[0]=i;
                    answer[1]=o;
                    return answer;
                }
            }
        }
        return answer;
    }
}