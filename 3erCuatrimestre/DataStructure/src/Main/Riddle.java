package Main;

import java.util.Scanner;
/*
* Ejercicio 27
* Ingresar numeros del 1 - 9
* Preguntar si es par o impar
* Preguntar el residuo sobre dividir entre 5
* Motrar el numero concluido
*/

public class Riddle
{
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		int current, isPar, residue;
		String strPrint;
		
		System.out.println("Ingrese un número del 1 al 9");
		current = scan.nextInt();
		if (current < 0 || current > 9){
		    System.out.println("Ingrese un numero correcto");
				scan.close();
		    return;
		}
		
		System.out.println("El número es par(0) o impar(1)");
		isPar = scan.nextInt();
		if (isPar < 0 || isPar > 1){
		    System.out.println("Ingrese un numero correcto");
				scan.close();
		    return;
		}
		
		System.out.println("Cual es residuo de dividir entre 5 (0 al 4)");
		residue = scan.nextInt();
		switch(residue){
	      case 0:
            strPrint = isPar == 0 ? "El número es 0" : "El número es 5";
            break;
	      case 1:
            strPrint = isPar == 0 ? "El número es 6" : "El número es 1";
            break;
          case 2:
            strPrint = isPar == 0 ? "El número es 2" : "El número es 7";
            break;
          case 3:
            strPrint = isPar == 0 ? "El número es 8" : "El número es 3";
            break;
          case 4:
            strPrint = isPar == 0 ? "El número es 4" : "El número es 9";
            break;
          default:
            strPrint = "Coleque un numero valido del residuo 0 a 4";
		}
		
		System.out.println(strPrint);
		
		scan.close();
	}
}
