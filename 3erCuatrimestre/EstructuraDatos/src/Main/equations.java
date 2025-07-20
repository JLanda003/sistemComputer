package Main;

import java.util.Scanner;
import java.lang.Math;

public class equations {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    System.out.println("Ingrese el valor de A:");
    double scanA = scan.nextDouble();
    System.out.println("Ingrese el valor de B:");
    double scanB = scan.nextDouble();
    System.out.println("Ingrese el valor de C:");
    double scanC = scan.nextDouble();
    System.out.println("Ingrese el valor de D:");
    double scanD = scan.nextDouble();

    double equation1 = (scanA + scanB + scanC)/scanD;
    double equation2 = (Math.pow((scanA - scanB), 2)/scanC) - (Math.pow((scanA - scanB), 3)/scanD);

    System.out.println("Calculo de la ecuación 1: (a+b+c)/d es: " + equation1);
    System.out.println("Calculo de la ecuación 1: (a-b)^2/c - (a-b)^2/d es: " + equation2);
    scan.close();
  }
}
