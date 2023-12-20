package br.com.alura.loja.util;

import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

public class JPAUtil {

    private static final EntityManagerFactory FACTORY = Persistence
            .createEntityManagerFactory("loja");

    public static EntityManager getEntityManager() {
        return FACTORY.createEntityManager();
    }

    public static void beginTransaction(EntityManager em) {
        em.getTransaction().begin();
    }

    public static void commitAndCloseConnection(EntityManager em) {
        em.getTransaction().commit();
        em.close();
    }
}
