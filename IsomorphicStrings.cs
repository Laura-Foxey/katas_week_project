/*
Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.
*/

public class Solution {
    public bool IsIsomorphic(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var map = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
               
                if (map[s[i]] != t[i])
                {
                    return false;
                }
            }
            else if (map.ContainsValue(t[i]))
            {
                return false;
            }
            else 
            {
                map.Add(s[i], t[i]);
            }
        }

        return true;
    }
}