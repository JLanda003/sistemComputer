package Main;

import java.util.Scanner;

/*
 * Ejercicio 14
 * Comition
 * Una empresa solicita conocer el monto de comision correspondietne a una venta
 * Si la venta es menor a $1,000.00 -> 3% de comision
 * Si es mayor o igual a $1,000.00 -> 5% de comision
 */
public class Comition {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    double saleValue, comition;

    System.out.println("Ingrese el valor de la venta realizada");

    saleValue = scan.nextDouble();

    if (saleValue >= 1000.00) {
      System.out.println("La comision es mayor o igual a $1000.00");
      comition = saleValue * 0.05;
      System.out.println("La comision de la venta de: $"+ saleValue +" es de: $" + comition);
    } else {
      System.out.println("La comision es menor a $1000.00");
      comition = saleValue * 0.03;
      System.out.println("La comision de la venta de: $"+ saleValue +" es de: $" + comition);
    }


    scan.close();
  }
}
