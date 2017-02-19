using System;

namespace Project.DAL.Entity.Abstract
{
    public interface IDatesEntity
    {
        DateTime CreatedDate { get; set; }

        DateTime ModifiedDate { get; set; }
    }
}