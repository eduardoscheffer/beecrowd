// import java.io.IOException;
// import java.util.*;
 
// /**
//  * IMPORTANT: 
//  *      O nome da classe deve ser "Main" para que a sua solução execute
//  *      Class name must be "Main" for your solution to execute
//  *      El nombre de la clase debe ser "Main" para que su solución ejecutar
//  */
// public class Main {
 
//     public static void main(String[] args) throws IOException {
 
//         Locale.setDefault((Locale.US));
//         Scanner sc = new Scanner(System.in);

//         //JDBCPostgreSQLConnection db = new JDBCPostgreSQLConnection();
//         //db.connect();

//         List<Double> positivos = new ArrayList<>();

//         for (int i = 0; i < 6; i++) {
//             double num = sc.nextDouble();
//             if (num > 0)
//                 positivos.add(num);
//         }

//         System.out.println(positivos.size() + " valores positivos");
//         System.out.printf("%.1f%n",
//                 positivos.stream().mapToDouble(Double::doubleValue).average().orElse(0.0));

//         sc.close();
 
//     }
 
// }