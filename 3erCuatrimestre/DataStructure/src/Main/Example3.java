package Main;

// Calculadora
public class Example3
{
    public static void main(String[] args)
    {
        double num1 = 10.0;
        double num2 = 5.0;
        double res = 0.0;
        char op = '+'; //Seleccion +, -, *, /

        if (op == '+'){
            res = num1 + num2;
        } else if (op == '-'){
            res = num1 - num2;
        } else if (op == '*'){
            res = num1 * num2;
        } else if (op == '/'){
            if (num2 != 0){
                res = num1 / num2;
            } else {
                System.out.println("Err: Division por cero");
                return;
            }
        } else {
            System.out.println("Err: Operacion Invalida");
            return;
        }

        System.out.println("El resultado es igual a: " + Double.toString(res));
    }
}
//Joshua Landa Vivas