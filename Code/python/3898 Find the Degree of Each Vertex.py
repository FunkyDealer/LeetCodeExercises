# You are given a 2D integer array matrix of size n x n representing the adjacency matrix of an undirected graph with n vertices labeled from 0 to n - 1.

#    matrix[i][j] = 1 indicates that there is an edge between vertices i and j.
#    matrix[i][j] = 0 indicates that there is no edge between vertices i and j.

# The degree of a vertex is the number of edges connected to it.

# Return an integer array ans of size n where ans[i] represents the degree of vertex i.

class Solution:
    def findDegrees(self, matrix: list[list[int]]) -> list[int]:

        res = [] # result list

        # go throught matrix
        for n in range(len(matrix)):
            res.append(0)
            for i in matrix[n]:
                res[n] += i

        return res
        
		

		
class Solution:
    def findDegrees(self, matrix: list[list[int]]) -> list[int]:

     return [sum(arr) for arr in matrix]