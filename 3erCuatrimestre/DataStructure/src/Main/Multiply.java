package Main;

import java.util.Scanner;

/*
 * Ejercicio 35
 * Ingresa un numero m y n enteros positivos
 * multiplica sin usar operación de multiplicación
 */

public class Multiply {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int currentM = 0, currentN = 0, result=0;

    System.out.println("Ingresa un numero para M");
    currentM = scan.nextInt();

    while (currentM < 0) {
      System.out.println("Ingresa un numero para M");
      currentM = scan.nextInt();
    }

    System.out.println("Ingresa un numero para N");
    currentN = scan.nextInt();

    while (currentM < 0) {
      System.out.println("Ingresa un numero para N");
      currentN = scan.nextInt();
    }

    for(int i = 1; i <= currentN; i++){
      result = result + currentM;
    }

    System.out.println("Resultado de multiplicar: " + currentM + " por: " + currentN + " es: " + result);

    scan.close();
  }
}