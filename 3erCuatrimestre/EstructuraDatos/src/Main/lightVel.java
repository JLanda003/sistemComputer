package Main;
import java.util.Scanner;

public class lightVel {

	public static void main(String[] args) {
		double light = 299792458;
		
		Scanner scan = new Scanner(System.in);
		
		System.out.println("Ingrese la cantidad de días que desea valorar");

		double days = scan.nextDouble();
		double seconds = days * 86400.00;
		double convert = (seconds * light);
		double result =  convert / 1000.00;

		System.out.println("La conversión el recorrido por " + days + " días sobre la velocidad de la luz: " + result + " Km/s");

		scan.close();
	}

}
