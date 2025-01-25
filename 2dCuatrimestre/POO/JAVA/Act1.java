//JOSHUA LANDA VIVAS
//ING. SISTEMAS COMPUTACIONALES

//Requiero un programa que cambien un número de forma matematica
//Ejemplo 15 -> 51

import javax.swing.JOptionPane;

public class Act1 {
  public static void main(String[] args) {
    Integer number = 0;

    number = Integer.parseInt(JOptionPane.showInputDialog(null, "Ingrese el valor"));//52

    Integer firtsNumber = 0;
    Integer secondNumber = 0;

    firtsNumber = number / 10; //52 / 10 = 5
    secondNumber = number - firtsNumber * 10;//52 - 5 * 10
    Integer valuInteger = secondNumber * 10 + firtsNumber; // 2 * 10 + 5

    // JOptionPane.showMessageDialog(null, firtsNumber);
    // JOptionPane.showMessageDialog(null, secondNumber);
    JOptionPane.showMessageDialog(null, valuInteger);//25

    System.exit(0);
  }
}
