package Main;

import java.util.Scanner;

/*
 * Ejercicio 31
 * Elaborar un programa que lea un numero N positivo
 * Mostrar en pantalla sus posibles divisores
 */
public class PossibleDivision {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    int current = 0;

    System.out.println("Ingrese un número entero positivo");
      current = scan.nextInt();

    while(current <= 0){
      System.out.println("Ingrese un número entero positivo");
      current = scan.nextInt();
    }

    for(int i = 1; i <= current; i++){
      if(current % i == 0){
        System.out.println("Divisor: " + i);
      }
    }

    scan.close();
  }
}
