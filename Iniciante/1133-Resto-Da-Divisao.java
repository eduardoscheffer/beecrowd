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
        
        int x = sc.nextInt();
        int y = sc.nextInt();
        
        int start = Math.min(x, y);
        int end = Math.max(x, y);
        
        for (int i = start + 1; i < end; i++) {
            if (i % 5 == 2 || i % 5 == 3) System.out.println(i);
        }
        
        
        sc.close();
 
    }
 
}
