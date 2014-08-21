using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;
using Mindscape.LightSpeed.Logging;
using System.Configuration;
namespace ORMTodos
{
    public class LightSpeedRepository<T> : IDisposable where T : Entity<int>
    {
         private readonly IUnitOfWork _unitOfWork;
         public LightSpeedRepository()
        {
            var context = new LightSpeedContext<TODOsUnitOfWork>("default")
            {
                //ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString,
                IdentityMethod = IdentityMethod.IdentityColumn,
                QuoteIdentifiers = true,
                Logger = new TraceLogger()
            };
 
            _unitOfWork = context.CreateUnitOfWork();
            
        }
 
       
 
        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Query<T>().Where(predicate);
        }
 
        public IList<T> GetAll()
        {
            return _unitOfWork.Find<T>();
        }
 
        public void Add(T entity)
        {
            if (entity.Id > 0)
                _unitOfWork.Attach(entity);
            else
                _unitOfWork.Add(entity);
        }
 
        public void DeleteAll()
        {
            foreach (var entity in GetAll())
            {
                Delete(entity);
            }
        }
 
        public void Delete(T entity)
        {
            _unitOfWork.Remove(entity);
        }
 
        public T FindById(int id)
        {
            return _unitOfWork.FindById<T>(id);
        }
 
        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }
 
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
