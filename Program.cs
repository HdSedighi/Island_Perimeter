internal class Program{
 private static void Main(string[] args){
     int[][] grid = new int[][]{

        //[[0,1]]
        new int[]{1,1},
        //  new int[]{0,1,0,0},
        //  new int[]{1,1,1,0},
        //  new int[]{0,1,0,0},
        //  new int[]{1,1,0,0}
     };
     Solution sol = new Solution();
     Console.WriteLine(sol.IslandPerimeter(grid));
 }

}


