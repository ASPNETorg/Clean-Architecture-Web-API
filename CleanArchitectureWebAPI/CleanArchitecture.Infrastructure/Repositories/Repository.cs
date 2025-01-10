using CleanArchitecture.Domain.Data;
using CleanArchitecture.Domain.Models.DomainModels;
using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Application.Contracts;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        #region [- property -]
        private readonly ProjectDbContext _applicationDbContext;
        private DbSet<T> entities;
        #endregion

        #region [- Constructor -]
        public Repository(ProjectDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        #region [- Delete() -]
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }
        #endregion

        #region [- GetById() -]
        public T Get(Guid? Id)
        {
            return entities.SingleOrDefault(c => c.Id == Id);
        }
        #endregion

        #region [- GetAll() -]
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        #endregion

        #region [- Insert() -]
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }
        #endregion

        #region [- Remove() -]
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }
        #endregion

        #region [- save() -]
        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }
        #endregion

        #region [- Update() -]
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            _applicationDbContext.SaveChanges();
        } 
        #endregion
    }
}
