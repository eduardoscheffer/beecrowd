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

        int X = sc.nextInt();
        List<String> results = new ArrayList<>();

        for (int i = 2; i <= X; i += 2) {

            int square = (int) Math.pow(i, 2);
            String result = i + "^" + "2 = " + square;
            results.add(result);

        }

        results.forEach(System.out::println);

        sc.close();
 
    }
 
}