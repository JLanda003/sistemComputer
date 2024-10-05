import java.util.HashMap;
import java.util.Scanner;

/**
 * GradeCalification
 * El usuario requiere poder ingresar el valor de una calificacion(0->10)
 * Valide la calificacion en Insuficiente(<=5), Suficiente(<10), Excelente(=10)
 */
public class GradeCalification {

  public static void main(String[] args) {
    HashMap<String, String> lang = new HashMap<String, String>();
    //Agregamos los datos a la lista de idiomas
    lang.put("textWelcome", "Bienvenido a tu primer calculo de calificación, dependiendo del valor el estudiante tendra la siguientes valoración\n *Insuficiente: El estudiante tiene una calificación igual o menor a 5\n *Suficiente: El estudiante tiene una calificación menor a 10\n *Excelente: El estudiante tiene una calificación igual a 10.");
    lang.put("textScore", "Ingrese una calificacion numeral entre 0 a 10.");
    lang.put("textResult", "El estudiante cuenta con una calificación: %s, ya que su resultado es: %d");

    //Declaramos las variables para la calificacion
    Integer score = 0;
    //Declaramos la varible de texto
    String messageString = "";
    //Declaramos la varibale de inyeccion de datos
    Scanner data = new Scanner(System.in);

    System.out.println(lang.get("textWelcome"));
    System.out.println(lang.get("textScore"));
    //Validamos que el valor de entrada sea un numero
    if (!data.hasNextInt()) {
      System.out.println(lang.get("textScore"));

      data.close();
      
      return;
    }
    //Seteamos el valor del score
    score = data.nextInt();

    if (score < 0 || score > 10) {
      System.out.println(lang.get("textScore"));

      data.close();

      return;
    }
    if (score == 10) {
      messageString = String.format(lang.get("textResult"), "Excelente", score);
    }
    if (score < 10 && score >= 6) {
      messageString = String.format(lang.get("textResult"), "Suficiente", score);
    }
    if (score < 6) {
      messageString = String.format(lang.get("textResult"), "Insuficiente", score);
    }
    
    System.out.println(messageString);

    data.close();
  }
}