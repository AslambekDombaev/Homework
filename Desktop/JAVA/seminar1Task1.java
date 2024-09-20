import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;

public class seminar1Task1 {
    public static void main(String[] args) {
        System.out.println("Hello world!");
        LocalTime now = LocalTime.now();
        // LocalDateTime now = LocalDateTime.now();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("HH:mm:ss MM/dd/yyyy");
        System.out.println(formatter.format(LocalDateTime.now()));
    }
}