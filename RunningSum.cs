/*
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
*/

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        int[] result = Enumerable.Repeat(nums[0], nums.Length).ToArray();
        for (int i = 1; i < result.Length; i++)
        {
            result[i] = nums[i] + result[i - 1];
        }
        return result;
    }
}