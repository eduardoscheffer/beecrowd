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
        
        int[] count = new int[4];
        int n;
        
        do {
            
            n = sc.nextInt();
            if (n >= 1 && n < 4) {
                count[n]++;
            }
            
        } while(n != 4);
        
        System.out.println("MUITO OBRIGADO");
        System.out.printf("Alcool: %d%n", count[1]);
        System.out.printf("Gasolina: %d%n", count[2]);
        System.out.printf("Diesel: %d%n", count[3]);
        
        
        
        sc.close();
 
    }
 
}
