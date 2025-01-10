using CleanArchitecture.Domain.Models.DomainModels;
using CleanArchitecture.Application.Contracts;



namespace ServiceLayer.Services
{
    public class DepartmentService : ICustomService<Departments>
    {
        #region [- Property -]
        private readonly IRepository<Departments> _studentRepository;
        #endregion

        #region [- Ctor -]
        public DepartmentService(IRepository<Departments> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region [- delete() -]
        public void Delete(Departments entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Delete(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [- GetById() -]
        public Departments Get(Guid? Id)
        {
            try
            {
                var obj = _studentRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [- GetAll() -]
        public IEnumerable<Departments> GetAll()
        {
            try
            {
                var obj = _studentRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Departments entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Insert(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [- Remove() -]
        public void Remove(Departments entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Remove(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region [- Update() -]
        public void Update(Departments entity)
        {
            try
            {
                if (entity != null)
                {
                    _studentRepository.Update(entity);
                    _studentRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        } 
        #endregion
    }
}
