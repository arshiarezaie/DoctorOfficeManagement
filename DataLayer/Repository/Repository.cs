using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DataLayer.Repository
{
   public class Repository<TEntity> where TEntity :class
    {


        private DoctorOfficeManagementEntities _db;
        private DbSet<TEntity> _dbSet;

        public Repository(DoctorOfficeManagementEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public IEnumerable<TEntity> Take(int TakeCount)
        {
            IQueryable<TEntity> query = _dbSet;

            query = query.Take(TakeCount);

            return query.ToList();
        }


        public IEnumerable<TEntity> Skip(int SkipCount)
        {
            IQueryable<TEntity> query = _dbSet;

            query = query.Skip(SkipCount);

            return query.ToList();
        }


        public TEntity GetByPrimaryKey(object primaryKey)
        {
            return _dbSet.Find(primaryKey);
        }


        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);

            _db.Entry(entity).State = EntityState.Modified;

        }

        public void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }


        public void DeleteByPrimarykey(object primaryKey)
        {
            Delete(GetByPrimaryKey(primaryKey));
        }

        public void Clear(Expression<Func<TEntity,bool>> where = null)
        {
            foreach (TEntity entity in Get(where))
            {
                _dbSet.Remove(entity);
            }
        }


        public bool IsExist(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.Any();
        }



    }
}
