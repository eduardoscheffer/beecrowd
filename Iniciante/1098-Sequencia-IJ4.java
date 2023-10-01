import java.io.IOException;
import java.util.*;
import java.text.DecimalFormat;
 
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
        DecimalFormat df = new DecimalFormat("0.0");

        double i, j;
        i = 0.0;
        j = 1.0;

        while (i <= 2.0) {
            for (int k = 0; k < 3; k++) {
                if (df.format(i).endsWith("0")) // se for 0.0 1.0 ou 2.0
                    System.out.println("I=" + df.format(i).charAt(0) + " J=" + df.format(j).charAt(0));
                else
                    System.out.println("I=" + String.format("%.1f", i) + " J=" + String.format("%.1f", j));
                j += 1;
            }
            i += 0.2;
            j = i + 1.0;
        }

        sc.close();
 
    }
 
}