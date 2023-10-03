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

        while (true) {
            int x = sc.nextInt();
            int y = sc.nextInt();

            if (x <= 0|| y <= 0) break;

            int sum = 0;
            StringBuilder sb = new StringBuilder();

            int start = Math.min(x, y);
            int end = Math.max(x, y);

            for (int i = start; i <= end; i++) {
                sum += i;
                sb.append(i).append(" ");
            }

            String result = sb.toString();
            System.out.println(result + "Sum=" + sum);
        }

        sc.close();
 
    }
 
}