/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package jpa;

import booking.Attractie;
import java.io.Serializable;
import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Query;
import javax.persistence.EntityNotFoundException;
import javax.persistence.criteria.CriteriaQuery;
import javax.persistence.criteria.Root;
import jpa.exceptions.NonexistentEntityException;

/**
 *
 * @author Michael
 */
public class AttractieJpaController implements Serializable {

    public AttractieJpaController(EntityManagerFactory emf) {
        this.emf = emf;
    }
    private EntityManagerFactory emf = null;

    public EntityManager getEntityManager() {
        return emf.createEntityManager();
    }

    public void create(Attractie attractie) {
        EntityManager em = null;
        try {
            em = getEntityManager();
            em.getTransaction().begin();
            em.persist(attractie);
            em.getTransaction().commit();
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }

    public void edit(Attractie attractie) throws NonexistentEntityException, Exception {
        EntityManager em = null;
        try {
            em = getEntityManager();
            em.getTransaction().begin();
            attractie = em.merge(attractie);
            em.getTransaction().commit();
        } catch (Exception ex) {
            String msg = ex.getLocalizedMessage();
            if (msg == null || msg.length() == 0) {
                int id = attractie.getAttractionID();
                if (findAttractie(id) == null) {
                    throw new NonexistentEntityException("The attractie with id " + id + " no longer exists.");
                }
            }
            throw ex;
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }

    public void destroy(int id) throws NonexistentEntityException {
        EntityManager em = null;
        try {
            em = getEntityManager();
            em.getTransaction().begin();
            Attractie attractie;
            try {
                attractie = em.getReference(Attractie.class, id);
                attractie.getAttractionID();
            } catch (EntityNotFoundException enfe) {
                throw new NonexistentEntityException("The attractie with id " + id + " no longer exists.", enfe);
            }
            em.remove(attractie);
            em.getTransaction().commit();
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }

    public List<Attractie> findAttractieEntities() {
        return findAttractieEntities(true, -1, -1);
    }

    public List<Attractie> findAttractieEntities(int maxResults, int firstResult) {
        return findAttractieEntities(false, maxResults, firstResult);
    }

    private List<Attractie> findAttractieEntities(boolean all, int maxResults, int firstResult) {
        EntityManager em = getEntityManager();
        try {
            CriteriaQuery cq = em.getCriteriaBuilder().createQuery();
            cq.select(cq.from(Attractie.class));
            Query q = em.createQuery(cq);
            if (!all) {
                q.setMaxResults(maxResults);
                q.setFirstResult(firstResult);
            }
            return q.getResultList();
        } finally {
            em.close();
        }
    }

    public Attractie findAttractie(int id) {
        EntityManager em = getEntityManager();
        try {
            return em.find(Attractie.class, id);
        } finally {
            em.close();
        }
    }

    public int getAttractieCount() {
        EntityManager em = getEntityManager();
        try {
            CriteriaQuery cq = em.getCriteriaBuilder().createQuery();
            Root<Attractie> rt = cq.from(Attractie.class);
            cq.select(em.getCriteriaBuilder().count(rt));
            Query q = em.createQuery(cq);
            return ((Long) q.getSingleResult()).intValue();
        } finally {
            em.close();
        }
    }
    
}
