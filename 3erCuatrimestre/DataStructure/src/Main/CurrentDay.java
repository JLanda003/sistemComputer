package Main;

import java.util.Scanner;
/*
Ejercicio 26
* Ingresar numeros del 1 - 7
* Mostrar día de la semana
*/

public class CurrentDay
{
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int current;
		String strPrint;
		
		System.out.println("Ingrese un número del 1 al 7");
		current = scan.nextInt();
		
		switch(current){
	      case 1:
            strPrint = "El día es: Domingo";
            break;
          case 2:
            strPrint = "El día es: Lunes";
            break;
          case 3:
            strPrint = "El día es: Martes";
            break;
          case 4:
            strPrint = "El día es: Miercoles";
            break;
          case 5:
            strPrint = "El día es: Jueves";
            break;
          case 6:
            strPrint = "El día es: Viernes";
            break;
          case 7:
            strPrint = "El día es: Sabado";
            break;
          default:
            strPrint = "Coleque un numero valido del 1 al 7";
		}
		
		System.out.println(strPrint);
		
		scan.close();
	}
}
