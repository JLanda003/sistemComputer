package Main;

import java.util.Scanner;

/*
 * Ejercicio 30
 * Ingresar numeros
 * sumar los primeros pares positivos
 */
public class SumPositivePar {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int current = 0, sum = 0;

    while (current >= 0 && current%2 == 0) {
      System.out.println("Ingrese un valor");
      current = scan.nextInt();

      sum = sum+current;
    };

    System.out.println("La suma de los numeros pares positivos es: " + sum);

    scan.close();
  }
}
