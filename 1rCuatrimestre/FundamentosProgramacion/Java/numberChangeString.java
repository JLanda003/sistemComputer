import java.util.HashMap;
import java.util.Scanner;

/**
 * numberChangeString
 * El usuario requiere poder ingresar el valor numerico del 0 al 99
 * y que este se convierta en su version escrita
 */
public class numberChangeString {

  public static void main(String[] args) {
    //Creamos la lista de idiomas
    HashMap<String, String> lang = new HashMap<String, String>();
    lang.put("textWelcome", "Bienvenido a tu primer convertidor de numeros a texto.");
    lang.put("textExplain", "Ingrese un número entre el 0 y el 99, para que este sea escrito.");
    lang.put("textInvalid", "Entrada inválida. Ingrese un número válido entre 0 y 99.");
    lang.put("textResult", "El número: %d, se escribe de la siguiente forma: %s");


    //Creamos Arreglo de Unidades
    String[] unidades = {
      //Numeros del 0 al 9
      "cero", "uno", "dos","tres",
      "cuatro", "cinco","seis",
      "siete", "ocho", "nueve",
      //Numeros de casos especiales
      "diez", "once", "doce", "trece",
      "catorce", "quince", "dieciséis",
      "diecisiete", "dieciocho", "diecinueve", "veinte"
    };
    //Creamos arreglo de Decenas
    String[] decenas = {
      "", "", "veinti", "treinta",
      "cuarenta", "cincuenta", "sesenta",
      "setenta", "ochenta", "noventa"
    };

    //Declaramos la variable del numero
    Integer numbInteger = null;

    //Declaramos la varibal de texto
    String messageString = "";

    //Declaramos la variable para inyeccion de datos;
    Scanner data = new Scanner(System.in);

    System.out.println(lang.get("textWelcome"));
    // Bucle para validar entrada
    while (numbInteger == null) {
      System.out.println(lang.get("textExplain"));

      // Verificamos si la entrada es un número y está entre 0 y 99
      if (data.hasNextInt()) {
        int input = data.nextInt();
        if (input >= 0 && input <= 99) {
          numbInteger = input; // Solo asigna si es un número válido
        } else {
          System.out.println(lang.get("textInvalid"));
        }
      } else {
        System.out.println(lang.get("textInvalid"));
        data.next(); // Descartar la entrada no válida
      }
      data.close();
    }

    //Creamos varibales para decenas y unidades
    Integer decInteger = (numbInteger / 10);
    Integer uInteger = numbInteger % 10;

    // Validamos números del 0 al 20
    if (numbInteger <= 20) {
      messageString = String.format(lang.get("textResult"), numbInteger, unidades[numbInteger]);
    }
    // Validamos que el número sea múltiplo de 10
    else if (uInteger == 0) {
      messageString = String.format(lang.get("textResult"), numbInteger, decenas[decInteger]);
    }
    // Caso especial para "veinti"
    else if (decInteger == 2) {
      messageString = String.format(lang.get("textResult"), numbInteger, decenas[decInteger] + unidades[uInteger]);
    }
    // Números mayores a 20 con decenas y unidades
    else {
      messageString = String.format(lang.get("textResult"), numbInteger, decenas[decInteger] + " y " + unidades[uInteger]);
    }

    System.err.println(messageString);
  }
}