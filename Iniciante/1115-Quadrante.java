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

            if (x == 0|| y == 0) break;

            if (x > 0 && y > 0)
                System.out.println("primeiro");
            else if (x > 0 && y < 0)
                System.out.println("quarto");
            else if (x < 0 && y < 0)
                System.out.println("terceiro");
            else
                System.out.println("segundo");
        }

        sc.close();
 
    }
 
}
