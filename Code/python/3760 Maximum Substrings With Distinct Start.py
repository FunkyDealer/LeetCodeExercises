#You are given a string s consisting of lowercase English letters.

#Return an integer denoting the maximum number of you can split s into such that each substring
#starts with a distinct character (i.e., no two substrings start with the same character).


class Solution:
#solution that creates a hash set and then places each unique char in it
    def maxDistinct(self, s: str) -> int:
        
        seen = set()
        res = 0

        for c in s:
            if c not in seen:
                seen.add(c)
                res+=1
            
        return res
		
		
class Solution:
#python more efficient, you can convert a string into a hashset by just using "set(myString)". the solution to this problem is then the length of that set
    def maxDistinct(self, s: str) -> int:
                    
        return len(set(s))
		