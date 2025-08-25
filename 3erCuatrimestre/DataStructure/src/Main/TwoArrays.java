package Main;

import java.util.Arrays;
import java.util.Scanner;

/*
 * Ejercicio 60
 * Ingresa dos arreglos de 10 números enteros
 * Mezclarlo en un tercer arreglo
 * Mostrarlo en pantalla
 */
public class TwoArrays {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int[] numbersA = new int[10],
      numbersB = new int[10],
      union = new int[20];
    int index = 0;

    for (int i = 0; i < 10; i++) {
      System.out.println("Ingresa el número " + (i + 1) + ": ");
      numbersA[i] = scan.nextInt();
    }

    for (int i = 0; i < 10; i++) {
      System.out.println("Ingresa el número " + (i + 1) + ": ");
      numbersB[i] = scan.nextInt();
    }

    for (int i = 0; i < 10; i++) {
        union[index++] = numbersA[i];
        union[index++] = numbersB[i];
    }

    System.out.println("\nArreglo mezclado: " + Arrays.toString(union));
    scan.close();
  }
}
