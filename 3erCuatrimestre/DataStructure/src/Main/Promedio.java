package Main;

import java.util.Scanner;
/*
 * Ejercicio 29
 * Permite leer numeros
 * se para cuando se ingrese un valor negativo
 * Printea el promedio
 */
public class Promedio {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int current = 0, count = 0, sum = 0;

    System.out.println("Ingrese un valor: ");
    current = scan.nextInt();
    
    while (current >= 0) {
      count++;
      sum = sum + current;

      System.out.println("Ingrese un valor: ");
      current = scan.nextInt();      
    }

    System.err.println("El conteo es: " + count + ", el promedio: " + (sum/count));
    scan.close();
  }
}