package inventory.repository;

import inventory.model.Product;
import jakarta.persistence.*;
import java.util.List;

public class ProductRepository {
  private static final EntityManagerFactory emf =
  Persistence.createEntityManagerFactory("inventoryPU");

  public void save(Product p){
    EntityManager em=emf.createEntityManager();
    em.getTransaction().begin();
    em.persist(p);
    em.getTransaction().commit();
    em.close();
  }

  public List<Product> findAll(){
    EntityManager em=emf.createEntityManager();
    List<Product> list=em.createQuery("FROM Product",Product.class).getResultList();
    em.close();
    return list;
  }

  public void update(Product p){
    EntityManager em=emf.createEntityManager();
    em.getTransaction().begin();
    em.merge(p);
    em.getTransaction().commit();
    em.close();
  }

  public void delete(Long id){
    EntityManager em=emf.createEntityManager();
    em.getTransaction().begin();
    Product p=em.find(Product.class,id);
    em.remove(p);
    em.getTransaction().commit();
    em.close();
  }
}