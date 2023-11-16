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
 
        Scanner sc = new Scanner(System.in);
	    Locale.setDefault((Locale.US));
	    
		while (true) {
		    int n = sc.nextInt();
		    if (n == 0) break;
		    
		    for (int i = 1; i <= n; i++) {
		        if (i == n) {
		            System.out.println(i);
		        } else {
		            System.out.print(i + " ");
		        }
		    } 
		    
		}
		
		sc.close();
 
    }
 
}
