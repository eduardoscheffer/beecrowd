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
        List<Integer> ins = new ArrayList<>();
        List<Integer> outs = new ArrayList<>();

        for (int i = 0; i < X; i++) {

            Integer N = sc.nextInt();
            if (N >= 10 && N <= 20)
                ins.add(N);
            else outs.add(N);

        }

        System.out.println(ins.size() + " in");
        System.out.println(outs.size() + " out");

        sc.close();
 
    }
 
}