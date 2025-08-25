package Main;

import java.util.Scanner;

/*
 * Ejercicio 32
 * Ingresa 10 calificaciones
 * Muestra cuantas son mayor o igual a 70
 */

public class Exams {
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int current, result = 0;

    for (int i = 1; i < 10; i++){
      System.out.println("Ingrese un valor " + i);

      current = scan.nextInt();

      if (current >= 70){
        result++;
      }
    };

    System.out.println("Las calificaciones mayores o iguales a 70 son: " + result);

    scan.close();
  }
}
