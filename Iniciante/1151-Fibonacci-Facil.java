import java.util.Locale;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Locale.setDefault((Locale.US));
        Scanner sc = new Scanner(System.in);

        int n = sc.nextInt();

        int first = 0, second = 1;
        for (int i = 0; i < n; i++) {

            if (i == n - 1) System.out.print(first);
            else System.out.print(first + " ");

            int sum = first + second; // proximo termo da sequencia
            first = second; // atribuindo a soma ao proximo termo a ser printado
            second = sum;

        }

        sc.close();

    }

}