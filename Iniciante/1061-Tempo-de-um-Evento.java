import java.io.IOException;
import java.time.Duration;
import java.time.LocalDateTime;
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

        /*
        ENTRADA DE DADOS
        Dia 5
        08 : 12 : 23
        Dia 9
        06 : 13 : 23

        SAIDA DE DADOS:
        3 dia(s)
        22 hora(s)
        1 minuto(s)
        0 segundo(s)
        */

        String[] SdiaInicial = sc.nextLine().split(" ");
        int diaInicial = Integer.parseInt(SdiaInicial[1]);
        String[] ShoraInicial = sc.nextLine().replaceAll(" ", "").split(":");
        LocalDateTime inicio = LocalDateTime.of(2023, 4, diaInicial, Integer.parseInt(ShoraInicial[0]), Integer.parseInt(ShoraInicial[1]), Integer.parseInt(ShoraInicial[2]));
        //System.out.println(inicio); // 2023-04-05T08:12:23

        String[] SdiaFinal = sc.nextLine().split(" ");
        int diaFinal = Integer.parseInt(SdiaFinal[1]);
        String[] ShoraFinal = sc.nextLine().replaceAll(" ", "").split(":");
        LocalDateTime finalEvento = LocalDateTime.of(2023, 4, diaFinal, Integer.parseInt(ShoraFinal[0]), Integer.parseInt(ShoraFinal[1]), Integer.parseInt(ShoraFinal[2]));
        //System.out.println(finalEvento); // 2023-04-09T06:13:23

        Duration durationEvent = Duration.between(inicio, finalEvento);
        // System.out.println(durationEvent); // PT94H1M

        System.out.println(durationEvent.toDays() + " dia(s)");
        System.out.println(durationEvent.toHoursPart() + " hora(s)");
        System.out.println(durationEvent.toMinutesPart() + " minuto(s)");
        System.out.println(durationEvent.toSecondsPart() + " segundo(s)");

        sc.close();
 
    }
 
}