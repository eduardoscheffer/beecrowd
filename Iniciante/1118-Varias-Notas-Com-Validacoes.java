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
        double nota1, nota2, n = 1;

        while (n == 1) {

            nota1 = sc.nextDouble();
            while (nota1 > 10 || nota1 < 0) {
                System.out.println("nota invalida");
                nota1 = sc.nextDouble();
            }

            nota2 = sc.nextDouble();
            while (nota2 > 10 || nota2 < 0) {
                System.out.println("nota invalida");
                nota2 = sc.nextDouble();
            }

            double media = (nota2 + nota1) / 2;
            System.out.println(String.format("media = %.2f", media));

            System.out.println("novo calculo (1-sim 2-nao)");
            n = sc.nextInt();

            while (n != 1 && n != 2) {
                System.out.println("novo calculo (1-sim 2-nao)");
                n = sc.nextInt();
            }

        }
 
    }
 
}