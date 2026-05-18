#You are given a 0-indexed array of strings words and a character x.

#Return an array of indices representing the words that contain the character x.

#Note that the returned array may be in any order.

class Solution:
    def findWordsContaining(self, words: List[str], x: str) -> List[int]:
        res = []

        for s in range(0, len(words)):
            if x in words[s]:
                res.append(s)

        return res