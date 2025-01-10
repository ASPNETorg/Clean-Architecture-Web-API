using CleanArchitecture.Domain.Models.DomainModels;
using CleanArchitecture.Application.Contracts;


namespace ServiceLayer.Services
{
    public class ResultService : ICustomService<Results>
    {
        #region [- Property -]
        private readonly IRepository<Results> _studentRepository;
        #endregion

        #region [- Ctor -]
        public ResultService(IRepository<Results> studentRepository)
        {
            _studentRepository = studentRepository;
        }
        #endregion

        #region [- Delete() -]
        public void Delete(Results entity)
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
        public Results Get(Guid? Id)
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
        public IEnumerable<Results> GetAll()
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
        public void Insert(Results entity)
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
        public void Remove(Results entity)
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
        public void Update(Results entity)
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

