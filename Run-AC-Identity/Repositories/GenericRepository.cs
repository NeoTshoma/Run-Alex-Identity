using Microsoft.EntityFrameworkCore;
using Run_AC_Identity.Data;
using Run_AC_Identity.Interfaces;

namespace Run_AC_Identity {
    public class GenericRepository<T>: IGenericRepository<T> where T: class 
    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<T?> GetAsync(string id) {
            if (id == null) {
                return null;
            }
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync() {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity) {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<List<T>> AddRange(List<T> entities) {
            await _dbContext.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();

            return entities;
        }

        public async Task<bool> Exists(string id) {
            var entity = await GetAsync(id);

            return entity != null;
        }

        public async Task DeleteAsync(string id) {
            var entity = await GetAsync(id);

            if (entity != null) {
                _dbContext.Set<T>().Remove(entity);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity) {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

    }
}