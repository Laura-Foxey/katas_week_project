/*
Create a function called "FizzBuzz" that takes in an integer n as a parameter and prints the numbers 
    from 1 to n, replacing numbers divisible by 3 with "Fizz", numbers divisible by 5 with "Buzz", 
    and numbers divisible by both 3 and 5 with "FizzBuzz". 
*/

public class Solution {
    void FizzBuzz(int n) {
        for (int i = 1; i <= n; i++) 
        {
            
            if (i % 3 == 0) {
                output += "Fizz";
            }
            if (i % 5 == 0) {
                output += "Buzz";
            }
            if (output == "") {
                output = i.ToString();
            }
            
        }
    }
}