using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DAL.Entity.Abstract;

namespace Project.DAL.Repositories.Abstract
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity, in TKey> : IRepository
        where TEntity : class, IEntity<TKey> where TKey : IEquatable<TKey>
    {

        Task<TEntity> FindByAsync(TKey id);


        TEntity FindById(TKey id);


        IEnumerable<TEntity> FindByIds(IEnumerable<TKey> ids);


        Task<IEnumerable<TEntity>> FindByIdsAsync(IEnumerable<TKey> ids);


        IEnumerable<TEntity> FindByIds(IEnumerable<string> ids);


        Task<IEnumerable<TEntity>> FindByIdsAsync(IEnumerable<string> ids);


        //IEnumerable<TEntity> GetAll();


        //Task<IEnumerable<TEntity>> GetAllAsync();


        TEntity Insert(TEntity entity);


        TEntity Update(TEntity entity);


        void Delete(TKey id);


        void Delete(TEntity entity);


        IQueryable<TEntity> AsQueryable();
    }


    public interface IIntRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }


    public interface IGuidRepository<TEntity> : IRepository<TEntity, Guid> where TEntity : class, IEntity<Guid>
    {

    }


    public interface IStringRepository<TEntity> : IRepository<TEntity, string> where TEntity : class, IEntity<string>
    {

    }
}




