# Intuition
The problem is asking to calculate the perimeter of an island in a 2D grid. The island is represented by 1s and the water is represented by 0s. The grid cells are connected vertically and horizontally. The intuition here is to iterate over each cell in the grid and for each land cell, add 4 (for each side of the cell) to the perimeter. Then, for each adjacent land cell (up, down, left, right), subtract 1 from the perimeter.

# Approach
The approach is to iterate over the grid. For each cell that is land (1), add 4 to the perimeter. Then, check the adjacent cells. If there is a cell above and it is land, subtract 1 from the perimeter. If there is a cell below and it is land, subtract 1 from the perimeter. If there is a cell to the left and it is land, subtract 1 from the perimeter. If there is a cell to the right and it is land, subtract 1 from the perimeter. Finally, return the calculated perimeter.

# Complexity
Time complexity: The time complexity is $$O(n^2)$$, where n is the number of rows (or columns) in the grid. This is because we are iterating over each cell in the grid once.

Space complexity: The space complexity is $$O(1)$$, as we are not using any additional data structures that scale with the input size. The space used by the input grid is not counted towards the space complexity.
__________________________________________________________________________________________
# Create a new console project
dotnet new console -n IslandPerimeter

# Run the project
dotnet run
