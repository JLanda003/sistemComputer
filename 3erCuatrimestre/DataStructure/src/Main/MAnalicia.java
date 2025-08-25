package Main;

import java.util.Scanner;
/*
 * Valuación del siguiente programa
 * de acuerdo a los valores, se
 * realiza la formula para soluciones cuadraticas
 * La chicarronera
 */

public class MAnalicia {
  public static void main(String[] args) {
    double a, b, c, // Coeficientes para ax^2 + bx + c
    x1, x2, d; //Soluciones y determinantes
    Scanner scan = new Scanner(System.in);

    System.out.println("Ingresa el coeficiente A:");
    a = scan.nextDouble();
    System.out.println("Ingresa el coeficiente B:");
    b = scan.nextDouble();
    System.out.println("Ingresa el coeficiente C:");
    c = scan.nextDouble();

    d = (Math.pow(b,2) - (4*a*c));

    if(d<0){
      System.out.println("NO existe solución");
      scan.close();
      return;
    }

    x1=(-b+(Math.sqrt(d)/2*a));
    x2=(-b-(Math.sqrt(d)/2*a));
    System.out.println("Solución 1 del calculo: " + x1);
    System.out.println("Solución 2 del calculo: " + x2);
    scan.close();
  }
}
