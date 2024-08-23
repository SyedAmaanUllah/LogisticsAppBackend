using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsDAL.Repositories
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly LogisticsDbContext _dbContext;
        public Repository(LogisticsDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await _dbContext.Set<T>().FindAsync(id);
        }

        public void RemoveAsync(T entity)
        {
             _dbContext.Set<T>().Remove(entity);    
        }

        public void UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
        }
    }
}
