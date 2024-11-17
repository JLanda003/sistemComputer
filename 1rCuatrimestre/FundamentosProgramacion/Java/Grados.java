import javax.swing.JOptionPane;

/**
 * Grados
 * Requiero convertir una temperarura Celcius a Farentheigh
 *  f = (1.8 * c) + 32
 */

public class Grados {

  public static void main(String[] args) {
    // Inicializamos las variables de grados Celcius y F
    Double gradeFaren = 0.0, gradeCelcius = 0.0;

    gradeCelcius = Double.parseDouble(JOptionPane.showInputDialog(null, "Ingresar los grados Celcius: "));

    gradeFaren = (1.8 * gradeCelcius) + 32;

    JOptionPane.showMessageDialog(null, "Los grados Celcius ingresado: " + gradeCelcius + " seria: " + gradeFaren + " F°");

    System.exit(0);

  }
}