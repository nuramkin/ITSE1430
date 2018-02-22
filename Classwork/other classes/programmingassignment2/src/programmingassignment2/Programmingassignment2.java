/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package programmingassignment2;

import java.util.Scanner;
import java.util.Stack;

/**
 *
 * @author nicholas.uramkin
 */
public class Programmingassignment2 {
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        int numCases;
        int numTowers;
        Stack towers = new Stack();
        
        Scanner in = new Scanner(System.in);
        System.out.print("Please Enter number of cases: ");
        numCases = in.nextInt();
        
        for (int i = numCases; i >= 0; i--)
        {
            System.out.print("Please enter the number of towers: ");
            numTowers = in.nextInt();
            
            System.out.print("Please Enter line of heights: ");
            String towerHeights = in.nextLine();
            Scanner parser = new Scanner(towerHeights);
            String token;
            
            for (int a = numTowers; a >= 0; a--)
            {
                token = parser.next();
                towers.push(token);
                
            }
            
        }
        while ( !towers.empty() )
                {
                        System.out.print ( towers.pop() );
                        System.out.print ( ',' );
                }
        
        
        
        
    }
    
}
