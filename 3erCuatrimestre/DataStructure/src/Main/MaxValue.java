package Main;

import java.util.Scanner;

/*
 * MaxValue
 * Ingresa 3 valores y obten el mayor de los tres
 */
public class MaxValue {
  public static void main(String[] args) {
    int val1, val2, val3;

    Scanner scan = new Scanner(System.in);

    System.out.println("Ingrese el primer valor:");
    val1 = scan.nextInt();
    System.out.println("Ingrese el segundo valor:");
    val2 = scan.nextInt();
    System.out.println("Ingrese el tercer valor:");
    val3 = scan.nextInt();

    if (val1 > val2 && val1 > val3){
      System.out.println("Valor 1 es mayor");
    }
    if (val2 > val1 && val2 > val1){
      System.out.println("Valor 2 es mayor");
    }
    if (val3 > val1 && val3 > val2){
      System.out.println("Valor 3 es mayor");
    }

    scan.close();
  }
}