/*
You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
 */


 public class Solution {

    static Dictionary<int, int> memo = new() {{0, 1}, {1, 1}};
    public int ClimbStairs(int n) {
        if (memo.Contains(n)) return memo[n];
        var value = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        memo[n] = value;
        return value;
    }
}