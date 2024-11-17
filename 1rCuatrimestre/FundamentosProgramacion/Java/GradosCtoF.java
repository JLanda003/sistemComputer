import javax.swing.JOptionPane;

/**
 * GradosCtoF
 */
public class GradosCtoF {

  public static void main(String[] args) {
    Double gradeFaren = 0.0, gradeCelcius = 0.0;

    gradeFaren = Double.parseDouble(JOptionPane.showInputDialog(null, "Ingrese los grados Farenheit"));
    
    gradeCelcius = (gradeFaren - 32) / 1.8;

    JOptionPane.showMessageDialog(null, "Los grados Farentheit ingresado: " + gradeFaren + " seria: " + gradeCelcius + " C°");

    System.exit(0);
  }
}