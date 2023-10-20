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
	    
	    int n = sc.nextInt();
	    
	    for (int i = 1; i <= n; i++) {
	        
	        int j = i * i;
	        int k = i * i * i;
	        System.out.println(i + " " + j + " " + k);
	        j += 1;
	        k += 1;
	        System.out.println(i + " " + j + " " + k);
	    } 
	    
	    sc.close();
 
    }
 
}
