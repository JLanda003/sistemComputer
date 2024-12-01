import java.util.HashMap;
import java.util.Scanner;

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
    lang.put("textExplain2", "Ingrese el mes.\n Ingrese un numero del 1 al 12");
    lang.put("textExplain3", "Ingrese el año.\n Ingrese un numero del 2000 al 2100");
    lang.put("textInvalid", "Ingrese un valor correcto.");
    lang.put("textResult", "El siguiente dia es: %d, el siguiente mes es: %s, el siguiente año es: %d");

    /*Inicializamos la varible para mostrar el mes en texto*/
    String[] months = {
      "Enero", "Febrero",
      "Marzo", "Abril",
      "Mayo", "Junio",
      "Julio", "Agosto",
      "Septiembre","Octubre",
      "Noviembre","Diciembre"
    };

    //Declaramos las variables de ingreso
    Integer day = 0, month = 0, year = 0;

    //Declaramos la variable de texto
    String messageString = "";

    //Declaramos la variable para inyeccion de datos
    Scanner data = new Scanner(System.in);

    System.out.println(lang.get("textWelcome"));

    while (day == 0 && month == 0 && year == 0){
      System.out.println(lang.get("textExplain1"));
      if(data.hasNextInt()){
        day = data.nextInt();
        if(day > 0 && day <= 30){
          System.out.println(lang.get("textExplain2"));
          if(data.hasNextInt()){
            month = data.nextInt();
            if (month > 0 && month <= 12){
              System.out.println(lang.get("textExplain3"));
              if(data.hasNextInt()){
                year = data.nextInt();
                if(year <= 2000 && year >= 2100){
                  System.out.println(lang.get("textExplain3"));
                  year = 0;
                }
              }else{
                System.out.println(lang.get("textExplain2"));
                month = 0;
              }
            } 
          }
        }
        else{
          System.out.println(lang.get("textExplain1"));
          day = 0;
        }
      } else {
        System.out.println(lang.get("textInvalid"));
      }

      data.close();
    };

    day++;

    if(day > 30){
      day = 1;
      month++;
    }

    if(month > 12){
      month = 1;
      year++;
    }

    if(year > 2100) year = 2000;

    messageString = String.format(lang.get("textResult"), day, months[month-1], year);

    System.out.println(messageString);

  }
}