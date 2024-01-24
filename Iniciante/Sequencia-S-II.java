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
		
		double sum = 0.0;
		for (int i = 0; i <= 39; i++) {
		    sum += ((2 * i + 1)/Math.pow(2, i));
		}
		
		System.out.printf("%.2f\n", sum);
		
		sc.close();
 
    }
 
}
