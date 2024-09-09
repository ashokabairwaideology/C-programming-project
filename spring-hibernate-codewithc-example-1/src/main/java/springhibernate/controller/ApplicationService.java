package springhibernate.controller;

import java.util.List;

import javax.transaction.Transactional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import springhibernate.entity.Book;
import springhibernate.repository.BookRepository;

/**
 * A simple service class which delegates method calls to the underlying repository.
 *
 * This service needs to be transactional because some repository tasks (for example persisting entities) require transactions.
 *
 *
 * @author GHajba
 *
 */
@RestController
@Transactional
public class ApplicationService {

    @Autowired
    BookRepository repository;

    @RequestMapping("/books")
    public List<Book> loadBooks() {
        return this.repository.loadAll();
    }

    @RequestMapping(value = "/books", method = RequestMethod.POST)
    public void saveBook(@RequestBody Book book) {
        this.repository.save(book);
    }

}
