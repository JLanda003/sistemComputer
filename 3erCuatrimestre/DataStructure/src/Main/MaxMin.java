package Main;

import java.util.Scanner;

/*
 * Ejercicio 36
 * Ingrese N numeros
 * Mostrar el mayor y menor de los numeros
 * Mostrar su posición
 */

public class MaxMin {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int countNumbers = 0;

    System.out.println("¿Cuántos números se ingresaran? ");
    countNumbers = scan.nextInt();

    int[] numbers = new int[countNumbers];

    for (int i = 0; i < countNumbers; i++) {
      System.out.println("Ingresa el número " + (i + 1) + ": ");
      numbers[i] = scan.nextInt();
    }

    int max = numbers[0], postMax = 0, min = numbers[0], postMin= 0;

    for (int i = 1; i < countNumbers; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
            postMax = i;
        }
        if (numbers[i] < min) {
            min = numbers[i];
            postMin = i;
        }
    }

    System.out.println("El número mayor es: " + max + " en la posición " + (postMax + 1));
    System.out.println("El número menor es: " + min + " en la posición " + (postMin + 1));

    scan.close();
  }
}
