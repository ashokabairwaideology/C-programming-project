package springhibernate.repository;

import java.util.List;

import org.hibernate.SessionFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Repository;

import springhibernate.entity.Book;

/**
 * A simple repository to access data from the underlying database
 *
 * @author GHajba
 *
 */
@Repository
public class BookRepository {

    @Autowired
    private SessionFactory sessionFactory;

    /**
     * Saves an entity to the database.
     *
     * @param entity
     */
    public void save(Book book) {
        this.sessionFactory.getCurrentSession().saveOrUpdate(book);
    }

    /**
     * Loads all Book objects from the database with the simples method
     *
     * @return
     */
    public List<Book> loadAll() {
        return this.sessionFactory.getCurrentSession().createQuery("from Book b").list();
    }

}
