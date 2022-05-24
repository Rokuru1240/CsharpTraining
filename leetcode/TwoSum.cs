public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int index,complement;
        Dictionary<int, int> list = new Dictionary<int, int>();
        for(index=0;index<nums.Length;index++)
        {
            complement = target - nums[index];
            if(list.ContainsKey(complement))
            {
                return new int[] {list[complement],index};
            }
            if(!list.ContainsKey(nums[index]))
                list.Add(nums[index],index);
        }
        return null;
    }
}