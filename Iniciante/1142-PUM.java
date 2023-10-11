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
        int j = 1;
        
        for (int i = 1; i <= n; i++) {
            
            int k = j + 1;
            int l = k + 1;
            
            System.out.println(j + " " + k + " " + l + " PUM");
            
            j = j + 4;
            
        } 
        
        sc.close();
 
    }
 
}
