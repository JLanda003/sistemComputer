package Main;

import java.util.Scanner;

/*
 * Ejercicio 59
 * Ingrese 10 numeros
 * Ordene primero, ultimo, segundo, penultimo,
 */

public class Order {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int[] numbers = new int[10];
    int left = 0, right = numbers.length - 1;

    for (int i = 0; i < 10; i++) {
      System.out.println("Ingresa el número " + (i + 1) + ": ");
      numbers[i] = scan.nextInt();
    }

    System.out.println("Order n1, n9, n2, n8, ...");

    while (left <= right) {
        if (left == right) {
            System.out.println(numbers[left]);
        } else {
            System.out.println(numbers[left]);
            System.out.println(numbers[right]);
        }
        left++;
        right--;
    }

    scan.close();
  }
}
