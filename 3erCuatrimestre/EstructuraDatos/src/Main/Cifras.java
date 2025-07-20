package Main;
import java.util.Scanner;

/**
 * Ejercicio15
 * Ingrese un numero del 0 al 9999 y determine
 * las cifeas que tiene
 */
public class Cifras {

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);
    Integer numberInt = 0;

    System.out.println("Ingrese valor del 0 al 9999");
    numberInt = scan.nextInt();

    if ( numberInt >= 0 && numberInt <= 9999 ){
      if ( numberInt >= 1000 && numberInt < 10000 ){
        System.out.println("El valor " + " tiene 4 cifra");
      }
      if ( numberInt >= 100 && numberInt < 1000 ){
        System.out.println("El valor " + " tiene 3 cifra");
      }
      if ( numberInt >= 10 && numberInt < 100 ){
        System.out.println("El valor " + " tiene 2 cifra");
      }
      if ( numberInt < 10 ){
        System.out.println("El valor " + " tiene 1 cifra");
      }
    }else{
      System.out.println("Ingrese un numero correcto");
    }
    
    scan.close();
  }
}