using CleanArchitecture.Domain.Models.DomainModels;
using CleanArchitecture.Application.Contracts;


namespace ServiceLayer.Services
{
    public class SubjectGpasService : ICustomService<SubjectGpas>
    {
        #region [- Property -]
        private readonly IRepository<SubjectGpas> _studentRepository;
        #endregion

        #region [- Ctor -]
        public SubjectGpasService(IRepository<SubjectGpas> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region [- Delete() -]
        public void Delete(SubjectGpas entity)
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
        public SubjectGpas Get(Guid? Id)
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
        public IEnumerable<SubjectGpas> GetAll()
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
        public void Insert(SubjectGpas entity)
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
        public void Remove(SubjectGpas entity)
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
        public void Update(SubjectGpas entity)
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
