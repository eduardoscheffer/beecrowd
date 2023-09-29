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

        int n = sc.nextInt();
        sc.nextLine();

        int totalCoelhos = 0;
        int totalRatos = 0;
        int totalSapos = 0;

        for (int i = 0; i < n; i++) {

            String[] infoValues = sc.nextLine().split(" ");
            int quantityCobaias = Integer.parseInt(infoValues[0]);
            char typeOfCobaia = infoValues[1].toUpperCase().charAt(0);

            switch (typeOfCobaia) {
                case ('C') -> totalCoelhos += quantityCobaias;
                case ('R') -> totalRatos += quantityCobaias;
                case ('S') -> totalSapos += quantityCobaias;
            }

        }

        int totalCases = totalCoelhos + totalRatos + totalSapos;

        System.out.println("Total: " + totalCases + " cobaias");
        System.out.println("Total de coelhos: " + totalCoelhos);
        System.out.println("Total de ratos: " + totalRatos);
        System.out.println("Total de sapos: " + totalSapos);

        System.out.println("Percentual de coelhos: " + String.format("%.2f", (totalCoelhos / (double) totalCases) * 100) + " %");
        System.out.println("Percentual de ratos: " + String.format("%.2f", (totalRatos / (double) totalCases) * 100) + " %");
        System.out.println("Percentual de sapos: " + String.format("%.2f", (totalSapos / (double) totalCases) * 100) + " %");

        sc.close();
 
    }
 
}