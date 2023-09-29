import java.io.IOException;
import java.util.*;
 
/**
 * IMPORTANT: 
 *      O nome da classe deve ser "Main" para que a sua solução execute
 *      Class name must be "Main" for your solution to execute
 *      El nombre de la clase debe ser "Main" para que su solución ejecutar
 */
public class Main {
 
    public static void main(String[] args) throws IOException {
 
        Locale.setDefault((Locale.US));
        Scanner sc = new Scanner(System.in);

        int i, j;
        i = 1;
        j = 60;

        while (j >= 0) {
            System.out.println("I=" + i + " J=" + j);
            i += 3;
            j -= 5;
        }

        sc.close();
 
    }
 
}