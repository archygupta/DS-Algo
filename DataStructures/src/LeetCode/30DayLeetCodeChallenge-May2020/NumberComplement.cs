/*

Given a positive integer, output its complement number. The complement strategy is to flip the bits of its binary representation.

 

Example 1:

Input: 5
Output: 2
Explanation: The binary representation of 5 is 101 (no leading zero bits), and its complement is 010. So you need to output 2.
 

Example 2:

Input: 1
Output: 0
Explanation: The binary representation of 1 is 1 (no leading zero bits), and its complement is 0. So you need to output 0.
 

Note:

The given integer is guaranteed to fit within the range of a 32-bit signed integer.
You could assume no leading zero bit in the integer’s binary representation.
This question is the same as 1009: https://leetcode.com/problems/complement-of-base-10-integer/

*/

using System;

public class NumberComplement
{
    public int FindComplement(int num)
    {
        string number = Convert.ToString(num, 2);
        string newValue = string.Empty;
        foreach (var ch in number)
        {
            int val = ch - '0';
            val = val == 0 ? 1 : 0;
            newValue += val;
        }

        return Convert.ToInt32(newValue, 2);
    }
}