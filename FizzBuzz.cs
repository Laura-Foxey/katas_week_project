/*
Create a function called "FizzBuzz" that takes in an integer n as a parameter and prints the numbers 
    from 1 to n, replacing numbers divisible by 3 with "Fizz", numbers divisible by 5 with "Buzz", 
    and numbers divisible by both 3 and 5 with "FizzBuzz". 
*/

public class Solution {
    void FizzBuzz(int n) {
        //loop through each number between 1 to n
        for (int i = 1; i <= n; i++) 
        {
            //create an empty string
            //this will also clear out the current value of string from previous loop iteration
            string output = "";

            //given the int i, if divisible by 3, add "Fizz" to string
            if (i % 3 == 0) {
                output += "Fizz";
            }

            //if i is divisible by 5, add "Buzz" to string
            if (i % 5 == 0) {
                output += "Buzz";
            }
            //if the string was empty at this point, convert i to string and add it to output
            if (output == "") {
                output = i.ToString();
            }
            //print out the output
            Console.WriteLine(output);
        }
    }
}