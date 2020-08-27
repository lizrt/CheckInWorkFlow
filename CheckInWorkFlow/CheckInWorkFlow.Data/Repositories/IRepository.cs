using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CheckInWorkFlow.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace CheckInWorkFlow.Data.Repositories
{
     public interface IRepository < T > where T: IEntity {  
        IEnumerable < T > GetAll();  
        T Get(long id);  
        IEnumerable<T> EntityWithEagerLoad(Expression<Func<T, bool>> filter,string[] children);  

        T Insert(T entity);  
        void Update(T entity);  
        void Delete(T entity);  
    } 
}