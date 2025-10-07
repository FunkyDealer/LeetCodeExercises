/*
You are given a 0-indexed array of strings words and a character x.

Return an array of indices representing the words that contain the character x.

Note that the returned array may be in any order.
*/

public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        IList<int> indices = new List<int>();

        for (int y = 0; y < words.Length; y++) {
            for (int u = 0; u < words[y].Length; u++)
                {
                    if (words[y][u] == x) {
                         indices.Add(y);
                          break;
                        }
                }
        }
        return indices;
    }
}