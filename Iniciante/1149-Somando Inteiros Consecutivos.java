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
		Locale.setDefault(Locale.US);
		
		int A = sc.nextInt();
		int N = sc.nextInt();
		int somaTotal = 0;
		
		while(N <= 0) {
		    N = sc.nextInt();
		}
		
		for (int i = 0 ;i < N; i++) {
		    somaTotal += A + i;
		}
		
		System.out.println(somaTotal);
		
		sc.close();
 
    }
 
}
