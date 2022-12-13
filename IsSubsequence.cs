/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
*/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length > t.Length) { return false; }
        if (s == "" || t == "") { return true; }

        int score = 0;
        int j = 0;

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == s[j])
            {
                j++;
                score++;
            }
        }
        return score == s.Length;
    }
}