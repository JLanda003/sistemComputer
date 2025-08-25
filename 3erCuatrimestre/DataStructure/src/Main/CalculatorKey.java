package Main;

import java.util.Scanner;
/*
* Ejercicio 28
* Ingresar dos numeros
* Ingresa una clave + - * /
* Motrar el resultado
*/

public class CalculatorKey
{
	public static void main(String[] args) {
		Scanner scan = new Scanner(System.in);
		
		double currentA, currentB;
		String strPrint, key;
		
		System.out.println("Ingrese la clave (+  -  *  /)");
		key = scan.nextLine();
		
		System.out.println("Ingrese un el primer numero");
		currentA = scan.nextInt();
		
		System.out.println("Ingrese un el segundo numero");
		currentB = scan.nextInt();

		switch(key){
	      case "+":
            strPrint = Double.toString(currentA + currentB);
            break;
	      case "-":
            strPrint = Double.toString(currentA + currentB);
            break;
          case "*":
            strPrint = Double.toString(currentA + currentB);
            break;
          case "/":
            strPrint = Double.toString(currentA + currentB);
            break;
          default:
            strPrint = "Coleque una clave correcta";
		}
		
		System.out.println("El resultado es: " + strPrint);
		
		scan.close();
	}
}
