/*
Given a string s, find the length of the longest 
substring
 without repeating characters. 
*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int answer = 0;
        string chars = "";
        for(int i = 0; i < s.Length; i++)
        {
            if(!chars.Contains(s[i]))
            {
                chars += s[i];
            }
            else
            {
                if(chars.Count() > answer) 
                { 
                    answer = chars.Count();
                }
                i = i - chars.Count();
                chars = "";
            }
        }

        if (chars.Count() > answer) { answer = chars.Count();}
        return answer;
    }
}