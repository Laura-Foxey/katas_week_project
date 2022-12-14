/*
Given a string s, find the length of the longest 
substring
 without repeating characters. 
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int answer = 0;
        var chars = new HashSet<char>();

        for(int i = 0; i < s.Length; i++)
        {
            if(!chars.Contains(s[i]))
            {
                chars.Add(s[i]);
            }
            else
            {
                answer = Math.Max(answer, chars.Count());
                //resets the loop index i to the start of the current substring
                i = i - chars.Count();
                chars.Clear();
            }
        }

        // check if the current length of unique chars is greater than the current longest length after the loop has completed
        answer = Math.Max(answer, chars.Count());
        return answer;
    }
}