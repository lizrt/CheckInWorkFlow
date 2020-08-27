using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CheckInWorkFlow.Data.DataAccess;
using CheckInWorkFlow.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace CheckInWorkFlow.Data.Repositories
{
public class EFRepository < T > : IRepository < T > where T:class, IEntity {  
        private readonly CheckInContext context;  
        private DbSet <T> entities;  
        string errorMessage = string.Empty;  
        public EFRepository(CheckInContext context) {  
            this.context = context;  
            entities = context.Set<T> ();  
        }  
        public IEnumerable < T > GetAll() {  
            return entities.AsEnumerable();  
        }  
        public T Get(long id) {  
            return entities.SingleOrDefault(s => s.Id == id);  
        }  
        public T Insert(T entity) {  
            if (entity == null) {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Add(entity);  
            context.SaveChanges();  
            return entity;
        }  
        public  IEnumerable<T> EntityWithEagerLoad(Expression<Func<T, bool>> filter, string[] children)  
{  
            try  
            {  
                IQueryable<T> query = GetAll().AsQueryable();  
                foreach (string entity in children)  
                {  
                    query = query.Include(entity);  
  
                }  
                return  query.Where(filter).ToList();  
            }  
            catch(Exception e)  
            {  
                throw e;  
            }  
}
        public void Update(T entity) {  
            if (entity == null) {  
                throw new ArgumentNullException("entity");  
            }  
            context.SaveChanges();  
        }  
        public void Delete(T entity) {  
            if (entity == null) {  
                throw new ArgumentNullException("entity");  
            }  
            entities.Remove(entity);  
            context.SaveChanges();  
        }  
}
}