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
            
            int x = sc.nextInt();
            int y = sc.nextInt();
            
            if (y == 0) System.out.println("divisao impossivel");
            else {
                double result = (double) x / y;
                System.out.printf("%.1f\n", result);    
            }
            
        }
 
    }
 
}
