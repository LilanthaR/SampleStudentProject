using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using AbcCo.StdMng.Repository.Contracts;
using AbcCo.StdMng.Common.Lib.Log.Contracts;
using System.Data.Entity;
using AbcCo.StdMng.Common.Setting;

namespace AbcCo.StdMng.Repositories.DB.EF
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ILogger _logger;
        protected IAppSettings _appSettings;
        protected IStdMgtDbContext _context;
        //protected StdMgtDbContext _context;

        // [InjectionConstructor]
        public Repository(IStdMgtDbContext context, IAppSettings appSettings, ILogger logger)
        {

            this._context = context;
            this._appSettings = appSettings;
            this._logger = logger;

            //this._context = new StdMgtDbContext();
        }

        public bool Create(T obj)
        {

            _logger.LogInfo("General Repository : Creating Entiry");

            try
            {
                _context.Set<T>().Add(obj);
                _logger.LogInfo("General Repository : Creating Entiry : Success");
                return true;
            }
            catch (Exception e)
            {
                _logger.LogInfo("General Repository : Creating Entiry : Failed");
                _logger.LogError("Error : Repository Create", e);
                return false;
            }

        }

        public bool Delete(T obj)
        {
            try
            {
                _context.Set<T>().Remove(obj);
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Error : Repository Delete", e);
                return false;
            }
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault<T>(predicate);
        }

        public List<T> FindList(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where<T>(predicate).ToList();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public bool Save()
        {
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Error : Repository GetAll", e);
                return false;
            }
        }

        //public bool Save(T obj)
        //{
        //    try
        //    {
        //        _context.Set<T>().Add(obj);
        //        _context.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception edb)
        //    {
        //        return false;
        //    }
        //}

        public bool Update(T obj)
        {
            try
            {
                var edbstate = _context.Entry(obj);
                _context.Set<T>().Attach(obj);
                edbstate.State = EntityState.Modified;
                return true;
            }
            catch (Exception e)
            {
                _logger.LogError("Error : Repository Update", e);
                return false;
            }
        }
    }
}
