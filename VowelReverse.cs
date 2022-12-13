/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
*/

public class Solution {
    public string ReverseVowels(string s) {
        string vowels = "aeiouAEIOU";
        
        string vowelList = "";
        
        var result = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++)
        {
            if(vowels.Contains(s[i]))
            {
                vowelList += s[i];
            }
            result.Append(s[i]);
        }
        var temp = vowelList.ToCharArray().Reverse();
        vowelList = new string(temp.ToArray());
        int v = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if(vowelList.Contains(result[i]))
            {
                result[i] = vowelList[v];
                v++;
            }
        }
        return result.ToString();
    }
}