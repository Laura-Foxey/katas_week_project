     /*
     Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string ""
     */
     
     public class Solution {
        static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            //return the shortest string in the array
            int shortest = strs.OrderBy(s => s.Length).First();
            string prefix = "";

            //loop through the shortest string
            for (int i = 0; i < shortest.Length; i++)
            {
                //if all of the strings' first character match with the shortest string's, add it to prefix 
                if (strs.All(s => s[i] == shortest[i]))
                    prefix += shortest[i];
                //otherwise break out of the loop
                else
                    break;
            }
            return prefix;
        }
     }