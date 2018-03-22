/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tempconvert;

import java.util.Scanner;

/**
 *
 * @author Douglas Atkinson
 */
public class TempConvert {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        double celcius;
        double f;
        
        Scanner in = new Scanner(System.in);
        
        System.out.print("Enter the degrees in celcius: ");
        celcius = in.nextDouble();
        f = celciusToFahrenheit(celcius);
        System.out.println("" + celcius + " degrees celcius is " + f + " degrees fahrenheit");
        
        System.out.print("Enter the degrees in fahrenheit: ");
        f = in.nextDouble();
        TempConvert tc = new TempConvert();
        celcius = tc.fahrenheitToCelcius(f);
        System.out.println("" + f + " degrees fahrenheit is " + celcius + " degrees celcius");
    }
    
    static double celciusToFahrenheit(double celc) {
        return 9.0 / 5.0 * celc + 32.0;
    }
    
    double fahrenheitToCelcius(double fahr) {
        return 5.0 / 9.0 * (fahr - 32.0);
    }
    
}
