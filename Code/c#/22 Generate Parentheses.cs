//Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        string path = "";

        Backtrack(0, 0, n, path, result);

        return result;
    }

    void Backtrack(int leftCount, int rightCount, int n, string path, List<string> result)
    {
       // Console.WriteLine(path);

        if (leftCount == n && rightCount == n)
        {
            result.Add(path);
            return;
        }

        //if there's opening brackets than target
        if (leftCount < n) {
            //add opening bracket
            path = path + "(";
            Backtrack(leftCount + 1, rightCount, n, path, result);
            //backtrack by removing last character
            path = path.Remove(path.Length - 1);
        }

        //if there's less closing brackets than opening brackets
        if (rightCount < leftCount) {
            //add closing bracket
            path = path + ")";
            Backtrack(leftCount, rightCount + 1, n, path, result);
            //backtrack
            path = path.Remove(path.Length - 1);
        }
    }
}