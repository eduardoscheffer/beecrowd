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

        List<Integer> list = new ArrayList<>();

        for (int i = 0; i < 100; i++) {
            list.add(sc.nextInt());
        }

        System.out.println(Collections.max(list));
        System.out.println(list.indexOf(Collections.max(list)) + 1);

        sc.close();
 
    }
 
}