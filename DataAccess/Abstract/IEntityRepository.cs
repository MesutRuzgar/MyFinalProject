using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class:referans tip
    //T değişkenimizi kısıtlamak için kullanırız.
    //T yerine sadece referans tip atayabilmek için. ve T sadece IEntity olanları alır.
    //IEntity olabilir  veya IEntity implemente edenler olabilir.
    //IEntity yapmazsak herhangi bir referans tip koyabiliriz. Bunu engellemek için kullandık.
    //new() : new'lenebilir olmalı.
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
