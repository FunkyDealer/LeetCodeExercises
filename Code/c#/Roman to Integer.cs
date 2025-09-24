/*Roman to Integer
Given a roman numeral, convert it to an integer.

RunTime - 1ms
Beats 99.80%*/

public class Solution {

public int GetValue(char s) {
    if (s == 'I') return 1;
    if (s == 'V') return 5;
    if (s == 'X') return 10;
    if (s == 'L') return 50;
    if (s == 'C') return 100;
    if (s == 'D') return 500;
    if (s == 'M') return 1000;   
return 0;
}
    public int RomanToInt(string s) {
        
        List<string> numbers = new List<string>();
        int total = 0;

        int length = s.Length;

        for (int x = length - 1; x >= 0;) {
                 int value = GetValue(s[x]);
                 int nextValue = 0;
                 if (x > 0) nextValue = GetValue(s[x-1]);
                 if (value > nextValue) {
                    x = x - 2;
                    value = value - nextValue;
                 }
                 else {
                    x = x - 1;
                 }
            total = total + value;
        }
    return total;
    }
}



