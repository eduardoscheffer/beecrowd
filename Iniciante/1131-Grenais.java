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
        int vitoriasInter = 0, vitoriasGremio = 0, empates = 0, numGrenais = 0, n;

        do {

            numGrenais += 1;

            int golsInter = sc.nextInt();
            int golsGremio = sc.nextInt();

            if (golsInter > golsGremio) vitoriasInter++;
            if (golsGremio > golsInter) vitoriasGremio++;
            if (golsInter == golsGremio) empates++;

            System.out.println("Novo grenal (1-sim 2-nao)");
            n = sc.nextInt();

        } while (n != 2);

        System.out.println(numGrenais + " grenais");
        System.out.println("Inter:" + vitoriasInter);
        System.out.println("Gremio:" + vitoriasGremio);
        System.out.println("Empates:" + empates);

        if (vitoriasInter > vitoriasGremio && vitoriasInter > empates) {
            System.out.println("Inter venceu mais");
        } else if (vitoriasGremio > vitoriasInter && vitoriasGremio > empates) {
            System.out.println("Gremio venceu mais");
        } else {
            System.out.println("Nao houve vencedor");
        }

        sc.close();
 
    }
 
}