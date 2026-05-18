#You are given a string s. 
#The score of a string is defined as the sum of the absolute difference between the ASCII values of adjacent characters.

#Return the score of s.


class Solution:
    def scoreOfString(self, s: str) -> int:
        
        res = 0

        for x in range(1, len(s)):
           #print("|", ord(s[x-1]), " - ", ord(s[x]), "| = ", abs(ord(s[x-1]) - ord(s[x])))
           res += abs(ord(s[x-1]) - ord(s[x]))


        return res