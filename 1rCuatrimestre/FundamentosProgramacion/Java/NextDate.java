import java.util.HashMap;

/**
 * NextDate
 * El usuario requiere poder ingresar una fecha, por dias, mes y año
 * y que se le indique el siguiente dia, tomando en cuenta que
 * cada mes tiene 30 dias.
 */
public class NextDate {

  public static void main(String[] args) {
    HashMap<String, String> lang = new HashMap<String, String>();
    lang.put("textWelcome", "Bienvenido a tu primer calendario.");
    lang.put("textExplain1", "Ingrese el día.\n Ingrese un numero del 1 al 30");
    lang.put("textExplain1", "Ingrese el mes.\n Ingrese un numero del 1 al 30");
    lang.put("textExplain1", "Ingrese el año.\n Ingrese un numero del 2000 al 2100");
    lang.put("textInvalid", "Ingrese un valor correcto.");

    String[] meses = {
      "", ""
    };

  }
}