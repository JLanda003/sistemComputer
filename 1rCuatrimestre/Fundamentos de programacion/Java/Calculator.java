//Importacion de librerias
import java.util.HashMap;
import java.util.Scanner;

/**
 * calculator
 */
public class Calculator {
  public static void main(String[] args) {
    //Declaraciones de varibales de idiomas
    HashMap<String, String> lang = new HashMap<String, String>();
    //Agregamos los datos a la lista de idiomas
    lang.put("textWelcome", "Bienvenido a tu primera calculadora\nPor favor ingrese el numero de la operacion que desea realizar\n1-Suma\n2-Resta\n3-Multiplicación\n4-División");
    lang.put("textFNumber", "Ingresa el primer número");
    lang.put("textSNumber", "Ingresa el Segundo número");
    lang.put("textResult", "El resultado de %d y %d es: %d ");
    lang.put("textError", "Ingrese una operación valida");
    //Declaramos las variables para los numeros
    Integer select = 0;
    Integer firstNumbInt = 0;
    Integer secondNumbInt = 0;
    //Declaramos la varibale del texto;
    String messageResult = "";
    //Declaramos la variable para inyectar los datos
    Scanner data = new Scanner(System.in);

    System.out.println( lang.get("textWelcome") );
    select = data.nextInt();
    System.out.println( lang.get("textFNumber") );
    firstNumbInt = data.nextInt();
    System.out.println( lang.get("textSNumber") );;
    secondNumbInt = data.nextInt();
    switch (select) {
      case 1:
        messageResult = String.format( lang.get("textResult"), firstNumbInt, secondNumbInt, ( firstNumbInt + secondNumbInt ) );
      break;
      case 2:
        messageResult = String.format( lang.get("textResult"), firstNumbInt, secondNumbInt, ( firstNumbInt - secondNumbInt ) );
      break;
      case 3:
        messageResult = String.format( lang.get("textResult"), firstNumbInt, secondNumbInt, ( firstNumbInt * secondNumbInt ) );
      break;
      case 4:
        messageResult = (secondNumbInt != 0)
          ? String.format( lang.get("textResult"), firstNumbInt, secondNumbInt, (firstNumbInt / secondNumbInt) )
          : "No se puede dividir por cero.";
      break;
      default:
        System.out.println( lang.get("textError") );
      break;
    }
    System.out.println(messageResult);
    data.close();
  }
}