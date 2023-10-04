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

        int contadorNotasValidas = 0;
        double somaDasNotas = 0.0;

        do {
            double nota = sc.nextDouble();

            if (nota < 0 || nota > 10) {
                System.out.println("nota invalida");
            } else {
                somaDasNotas += nota;
                contadorNotasValidas++;
            }
        } while (contadorNotasValidas < 2);
        
        double media = somaDasNotas / 2;
        System.out.printf("media = %.2f%n", media);
 
    }
 
}
