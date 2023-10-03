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

        int n = sc.nextInt();

        for (int i = 0; i < n; i++) {

            int total = 0;

            int first = sc.nextInt();
            int second = sc.nextInt();

            if (second > first) {
                for (int j = first + 1; j < second; j++) {
                    if (j % 2 != 0) total += j;
                }
            }

            else {
                for (int j = second + 1; j < first; j++) {
                    if (j % 2 != 0) total += j;
                }
            }

            System.out.println(total);

        }

        sc.close();
 
    }
 
}