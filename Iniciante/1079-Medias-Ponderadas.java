import java.io.IOException;
import java.util.*;
import java.util.stream.Collectors;
 
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
        List<Double> mediasPonderadas = new ArrayList<>();

        int X = sc.nextInt();
        for (int i = 0; i < X; i ++) {

            double n1 = sc.nextDouble();
    		double n2 = sc.nextDouble();
    		double n3 = sc.nextDouble();
    		double media = ((n1*2) + (n2*3) + (n3*5)) / 10;
            
            mediasPonderadas.add(media);

        }
        
        for (Double media : mediasPonderadas) {
            System.out.printf("%.1f%n", media);
        }

        sc.close();
 
    }
 
}
