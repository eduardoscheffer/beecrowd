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
		List<Integer> notas = new ArrayList<>();
		
		while (true) {
		    int n = sc.nextInt();
		    
		    if (n < 0) break;
		    
		    notas.add(n);
		}
		
		if (notas.size() > 0) {
		    
		    double media = notas.stream()
                .mapToDouble(Integer::doubleValue) // Convertendo para double
                .sum();
		    System.out.printf("%.2f\n", (media / notas.size()));
		    
		}
		
		sc.close();
 
    }
 
}
