package Main;

import java.util.Scanner;

/*
 * Increase
 * En una empresa requiere obtener el aumento de empleados segun por su categoria
 * S -> Sindicalizado > 20%
 * C -> Confianza > 10%
 * D -> Directivo > 5%
 * E -> Ejecutivo > 0%
 * El programa debe solicitar la clave de categoria y el sueldo actual del empleado
 * y mostrar el nuevo salario
 */

public class Increase{
  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    double current, afterIncrease, increase = 1;
    String key;

    System.out.println("Ingrese la clave de tipo de contrato");
    key = scan.nextLine().toLowerCase();
        switch (key) {
      case "s":
        increase = 0.2;
        break;
      case "c":
        increase = 0.1;
        break;
      case "d":
        increase = 0.05;
        break;
      case "e":
        increase = 0.0;
        break;
      default:
        System.out.println("Ingrese una clave valida");
        break;
    }

    if (increase < 1){
      System.out.println("Ingrese el saldo actual del empleado");
      current = scan.nextDouble();
      afterIncrease = (current * increase) + current;
  
      System.out.println("El incremento del colaborado con clave: " + key.toUpperCase() + " es de: " + (increase * 100) + " y su sueldo sera de: "  + afterIncrease);
    } else {
      scan.close();
      return;
    }

    scan.close();

  }
}