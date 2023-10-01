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
        j = 7;

        while (i <= 9) {
            for (int k = 0; k < 3; k++) {
                System.out.println("I=" + i + " J=" + j);
                j--;
            }
            i += 2;
            j = i + 6;
        }

        sc.close();
 
    }
 
}