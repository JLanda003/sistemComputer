package Main;

import java.util.Scanner;

/*
 * Ejercicio 58
 * Solicita 5 numeros
 * Invierte el orden de los valores
 * Mostrarlos en pantalla
 */

public class Invert {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int[] numbers = new int[5];

    for (int i = 0; i < 5; i++) {
      System.out.println("Ingresa el número " + (i + 1) + ": ");
      numbers[i] = scan.nextInt();
    }

    System.out.println("Invertido:");
    for (int j = 4; j >= 0; j--){
      System.out.println(numbers[j]);
    }

    scan.close();
  }
}
