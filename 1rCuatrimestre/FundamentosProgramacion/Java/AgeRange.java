import java.util.HashMap;
import java.util.Scanner;

public class AgeRange {
  public static void main(String[] args) {
    //Declaraciones de varibales de idiomas
    HashMap<String, String> lang = new HashMap<String, String>();
    //Agregamos los datos a la lista de idiomas
    lang.put("textWelcome", "Bienvenido a tu primer rango de edades");
    lang.put("textFNumber", "Por favor ingrese la primera edad.");
    lang.put("textSNumber", "Por favor ingrese la segunda edad.");
    lang.put("textResult", "Las edades dentro del rango de edad entre: %d y %d es el siguiente");
    lang.put("textError", "Por favor, ingrese una edad valida.");
    //Declaramos las variables para los numeros
    Integer firstNumbInt = 0;
    Integer secondNumbInt = 0;
    //Declaramos la varibale del texto;
    String messageResult = "";
    String rangeResult = "";
    //Declaramos la variable para inyectar los datos
    Scanner data = new Scanner(System.in);

    System.out.println( lang.get("textWelcome") );
    System.out.println( lang.get("textFNumber") );
    firstNumbInt = data.nextInt();
    System.out.println( lang.get("textSNumber") );;
    secondNumbInt = data.nextInt();

    messageResult = String.format( lang.get("textResult"), firstNumbInt, secondNumbInt );

    if (firstNumbInt >= 0 && secondNumbInt >= 0) {
      System.out.println(messageResult);
      for (int i = firstNumbInt; i <= secondNumbInt; i++) {
        rangeResult = (rangeResult == "")
          ? "" + i
          : rangeResult + ", " + i;
      }
    } else {
      System.out.println(lang.get("textError"));
    }
    System.out.println(rangeResult);
    data.close();
  }
}
