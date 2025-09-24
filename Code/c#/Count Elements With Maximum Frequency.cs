/*Count Elements With Maximum Frequency

You are given an array nums consisting of positive integers.
Return the total frequencies of elements in nums such that those elements all have the maximum frequency.
The frequency of an element is the number of occurrences of that element in the array.
*/

public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        
        Dictionary<int,int> frequencies = new Dictionary<int,int>(); //dictionary with number and its frequency

        int currentMaxFrequency = 0; //highest frequency count
        foreach (int i in nums)
        {
            if (frequencies.Count == 0) {
                frequencies.Add(i, 1);
                currentMaxFrequency = 1;
            }
            else if (!frequencies.ContainsKey(i)) {
             frequencies.Add(i, 1); //add new number in case its not in yet
            }
            else if (frequencies.ContainsKey(i)) {
            frequencies[i]++; //add frequency ammount to key number
            if (frequencies[i] > currentMaxFrequency) currentMaxFrequency = frequencies[i];
            }
        }

        int maxFrequencyNumber = 0;
        foreach (var f in frequencies) { //search dictionary for numbers that have max frequency
            if (f.Value == currentMaxFrequency) maxFrequencyNumber += f.Value; //add ammount of times those numbers appear
        }
        
        return maxFrequencyNumber;
    }
}