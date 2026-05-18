#You are given an integer n.

#Define its mirror distance as: abs(n - reverse(n))​​​​​​​ where reverse(n) is the integer formed by reversing the digits of n.

#Return an integer denoting the mirror distance of n​​​​​​​.

#abs(x) denotes the absolute value of x.

class Solution:
    def mirrorDistance(self, n: int) -> int:
        
        return abs(n - self.reverse(n))

    def reverse(self, n: int) -> int:
        rev = 0
        while n > 0:
            a = n % 10
            rev = rev * 10 + a
            n = n // 10
        return rev