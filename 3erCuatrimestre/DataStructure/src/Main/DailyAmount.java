package Main;

import java.util.Scanner;

/*
 * Ejercicio 34
 * Leer N ventas hechas por una tienda en el dia
 * mostrar el monto total de ventas y el promedio
 */

public class DailyAmount {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    double currentSale = 0, count = 0, sumSale = 0;

    System.out.println("Ingrese un monto de venta");
    currentSale = scan.nextDouble();

    while(currentSale > 0){
      count++;
      sumSale = sumSale + currentSale;
      System.out.println("Ingrese un monto de venta");
      currentSale = scan.nextDouble();
    }

    System.out.println("El monto total es: " + sumSale + ", el promedio es: " + (sumSale/count));

    scan.close();
  }
}
