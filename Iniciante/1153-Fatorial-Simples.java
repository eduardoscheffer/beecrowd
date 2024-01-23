import java.io.IOException;
import java.util.Locale;
import java.util.Scanner;
 
/**
 * IMPORTANT: 
 *      O nome da classe deve ser "Main" para que a sua solução execute
 *      Class name must be "Main" for your solution to execute
 *      El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {
    public static void main(String[] args) {
        Locale.setDefault((Locale.US));
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        System.out.println(factorialOf(n));

    }

    static int factorialOf(int n) {
        if (n == 1 || n == 0) return 1;
        else return n * factorialOf(n -1);
    }

}