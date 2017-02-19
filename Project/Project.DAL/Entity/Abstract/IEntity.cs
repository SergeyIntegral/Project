using System;

namespace Project.DAL.Entity.Abstract
{
    public interface IEntity<TKey> where TKey : IEquatable<TKey>
    {
        TKey Id { get; set; }
    }

    public interface IIntEntity : IEntity<int>
    {
    }


    public interface IGuidEntity : IEntity<Guid>
    {

    }

    public interface IStringEntity : IEntity<string>
    {

    }

}