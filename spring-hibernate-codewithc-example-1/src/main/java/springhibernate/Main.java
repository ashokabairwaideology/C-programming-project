package springhibernate;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

/**
 * This is the main entry point of the application.
 *
 * It kicks-on Spring gathers the required service from the application context, inserts a book into the database and prints out every book
 * entry to the standard output.
 *
 * @author GHajba
 *
 */
@SpringBootApplication
public class Main {
    public static void main(String[] args) {
        SpringApplication.run(Main.class, args);
    }
}
