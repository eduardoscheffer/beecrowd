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
 
        Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		int n = sc.nextInt();
		for (int i = 0; i < n; i++) {
		    
		    int X = sc.nextInt();
		    int Y = sc.nextInt();
		    int soma = 0, numImpares = 0;
		    while (numImpares < Y) {
		        if (X % 2 != 0) {
		            soma += X;
		            numImpares ++;
		        }
		        X++;
		    }
		    
		    System.out.println(soma);
		    
		} 
		
		sc.close();
 
    }
 
}
