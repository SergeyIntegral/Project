using System;
using System.ComponentModel.DataAnnotations;

namespace Project.DAL.Entity.Abstract
{
    public abstract class Entity<TKey>:IEntity<TKey> where TKey:IEquatable<TKey>
    {
        [Key]
        public virtual TKey Id { get; set; }
    }

    public abstract class IntEntity : Entity<int>, IIntEntity
    {

    }

    public abstract class GuidEntity : Entity<Guid>, IGuidEntity
    {

    }

    public abstract class StringEntity : Entity<string>, IStringEntity
    {

    }
}