import javax.swing.JOptionPane;

/**
 * Ejercicio15
 * Ingrese un numero del 0 al 9999 y determine
 * las cifeas que tiene
 */
public class Cifras {

  public static void main(String[] args) {
    Integer numberInt = 0;

    numberInt = Integer.parseInt(JOptionPane.showInputDialog(null, "Ingrese valor del 0 al 9999"));

    if ( numberInt >= 0 && numberInt <= 9999 ){
      if ( numberInt >= 1000 && numberInt < 10000 ){
        JOptionPane.showMessageDialog(null, "El valor " + " tiene 4 cifra");
      }
      if ( numberInt >= 100 && numberInt < 1000 ){
        JOptionPane.showMessageDialog(null, "El valor " + " tiene 3 cifra");
      }
      if ( numberInt >= 10 && numberInt < 100 ){
        JOptionPane.showMessageDialog(null, "El valor " + " tiene 2 cifra");
      }
      if ( numberInt < 10 ){
        JOptionPane.showMessageDialog(null, "El valor " + " tiene 1 cifra");
      }
    }else{
      JOptionPane.showMessageDialog(null, "Ingrese un numero correcto");
    }
    System.exit(0);
  }
}