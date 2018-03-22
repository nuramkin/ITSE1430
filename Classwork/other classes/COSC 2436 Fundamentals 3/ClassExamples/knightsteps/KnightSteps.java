/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package knightsteps;

import java.io.FileReader;
import java.io.IOException;
import java.util.Scanner;
import java.util.Queue;
import java.util.LinkedList;

/**
 *
 * @author douglas.atkinson
 */
public class KnightSteps {

    public static void main(String[] args) {
        
        Scanner in = null;
        try {
            in = new Scanner(new FileReader("knightsteps_input.txt"));
        }
        catch(IOException e) {
            e.printStackTrace();
        }
        
        // Get the number of cases
        int numCases = Integer.parseInt(in.nextLine());
        
        // Loop through and read the file
        // Call search on each iteration through the loop
        for(int i = 0; i < numCases; i++) {
            int n = Integer.parseInt(in.nextLine());
            String[] loc = in.nextLine().split(" ");
            int sRow = Integer.parseInt(loc[0]);
            int sCol = Integer.parseInt(loc[1]);
            loc = in.nextLine().split(" ");
            int tRow = Integer.parseInt(loc[0]);
            int tCol = Integer.parseInt(loc[1]);
            System.out.println(search(n, sRow, sCol, tRow, tCol));
        }
        
    }
    
    static int search(int n, int startX, int startY, int endX, int endY) {
        return minStepToReachTarget(new int[]{startX, startY},
                new int[]{endX, endY}, n);
    }
    
    static boolean isInBoard(int x, int y, int n) {
        return (x >= 1 && x <= n && y >= 1 && y <= n);        
    }
    
    static int minStepToReachTarget(int[] knightPos, int[] targetPos, int n) {
        int[] dx = {-2, -1, 1, 2, -2, -1, 1, 2};
        int[] dy = {-1, -2, -2, -1, 1, 2, 2, 1};
        
        Queue<Cell> q = new LinkedList<>(); // store knight board states
        
        q.offer(new Cell(knightPos[0], knightPos[1], 0));
        
        Cell t;     // temporary cell to look at
        int x, y;   // row and column
        
        boolean[][] visited = new boolean[n+1][n+1];
        visited[knightPos[0]][knightPos[1]] = true;
        
        while(!q.isEmpty()) {
            t = q.poll();
            visited[t.getX()][t.getY()] = true;
            
            if(t.getX() == targetPos[0] &&
               t.getY() == targetPos[1]) {
                return t.getDist();
            }
            
            for(int i = 0; i < 8; i++) {
                x = t.getX() + dx[i];
                y = t.getY() + dy[i];
                
                if(isInBoard(x, y, n) && !visited[x][y]) {
                    q.offer(new Cell(x, y, t.getDist() + 1));
                }
            }
        }
        return -1;
    }
}
