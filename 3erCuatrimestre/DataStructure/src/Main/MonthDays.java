package Main;

import java.util.Scanner;

/**
 * Ejercicio 23
 * Permite ingresar numeros del 1 al 12
 * Mostrara en pantalla
 * Días del mes
 * Nombre del mes
 */

public class MonthDays {

  public static void main(String[] args) {
    Scanner scan = new Scanner(System.in);

    int month;
    String daysMonth = "", messageString = "";

    System.out.println("Ingrese un numero del 1 al 12");

    month = scan.nextInt();

    /*Inicializamos la varible para mostrar el mes en texto*/
    String[] months = {
      "Enero", "Febrero",
      "Marzo", "Abril",
      "Mayo", "Junio",
      "Julio", "Agosto",
      "Septiembre","Octubre",
      "Noviembre","Diciembre"
    };

    switch (month) {
      case 1, 3, 5, 7, 8, 10, 12:
        daysMonth = "31";
        break;
      case 2:
        daysMonth = "28";
        break;
      case 4, 6, 9, 11:
        daysMonth = "30";
        break;
      default:
        messageString = "Ingrese un numero del 1 al 12";
        System.out.println(messageString);
        break;
    }

    if (messageString != ""){
      scan.close();
      return;
    }

    messageString = "El numero: " + month
      + " representa al mes: " + months[month - 1]
      + " y cuenta con: " + daysMonth + " dias";

    System.out.println(messageString);

    scan.close();
  }
}