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
		
		int X = sc.nextInt();
		int Z = sc.nextInt();
		
		while(Z <= X) {
		    Z = sc.nextInt();
		}
		
		int count = 0;
		int soma = 0;
		for (int i = X; soma <= Z; i++) {
		    soma += i;
		    count++;
		}
		
		System.out.println(count);
		
		sc.close();
 
    }
 
}
