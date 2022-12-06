     /*
     Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string ""
     */
     
     public class Solution {
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            int minLength = strs.Min(s => s.Length);
            string prefix = "";
            for (int i = 0; i < minLength; i++)
            {
                char c = strs[0][i];
                if (strs.All(s => s[i] == c))
                    prefix += c;
                else
                    break;
            }

            return prefix;
        }
     }