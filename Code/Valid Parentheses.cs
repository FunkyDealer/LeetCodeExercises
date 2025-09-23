/*Valid Parentheses

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

    Open brackets must be closed by the same type of brackets.
    Open brackets must be closed in the correct order.
    Every close bracket has a corresponding open bracket of the same type.*/


public class Solution {
//Use a stack that inserts and removes the target

public bool IsClose(char c) //is the character a closed parenthesis?
{
        if (c == ')' | c == ']' | c == '}') return true;
        else return false;
}

public char GetOpposite(char c) //Get the closed version
{
        switch (c) {
            case '(':
                return ')';
            case '[':
                return ']';
            case '{':
                return '}';
                default:
                return 'n';
        }
}

    public bool IsValid(string s) {        
        int length = s.Length;
        if (length == 1) return false; //1 length cases
        if (IsClose(s[0])) return false; //first char is closed case

        List<char> currentSearch = new List<char>();  //stack   

        currentSearch.Add(s[0]); //add the first character
        
        for (int x = 1; x < length; x++) {
            if (IsClose(s[x])) //if the character is closed
            {
                if (currentSearch.Count == 0) return false; //found a closed that wasn't oppened
                 if (s[x] == GetOpposite(currentSearch[0]))
                  {
                    currentSearch.RemoveAt(0); //found the correct matching closed parenthesis, remove from stack
                    }
                    else
                    {
                        return false;
                    }
            }           
            else
            {
                currentSearch.Insert(0, s[x]); //insert new open parenthesis at the top
            }
        }

        if (currentSearch.Count > 0) return false; //open parenthesis werent closd

        return true;
    }
}