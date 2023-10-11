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
        
        int sum = 0;
        
        for (int i = start; i <= end; i++) {
            if (i % 13 != 0) sum += i;
        }
        
        System.out.println(sum);
        
        sc.close();
 
    }
 
}
