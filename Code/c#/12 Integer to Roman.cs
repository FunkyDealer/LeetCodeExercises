//Convert a integer number into its roman numeral equivalent


public class Solution {
    public string IntToRoman(int num) {
        //dictionary of numbers and their corresponding roman numeral equivalents
        Dictionary<int, string> romanNums = new Dictionary<int,string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL"},
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },  
        };

        //result string, will append roman numeral to it to create the answer
        string res = "";
        //go throught the dictionary
        foreach (KeyValuePair<int, string> pair in romanNums) {
            if (num > 0) {
                // while the number is bigger or equal the the current key
                while (num >= pair.Key)
                {                                
                    res = res + pair.Value; //add value (roman numeral) to the result string
                    num -= pair.Key; //remove the key (int) from the number
                }
            }
        }

        return res;
    }
}