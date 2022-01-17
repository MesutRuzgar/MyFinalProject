using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//isim uzayını uyarlamayı unutma
//core katmanı diğer katmanları refarans almaz. Bağımsız olmalı
//Katmanları core taşıyınca en baştaki using Entites.Abstract; sildik, bağımsızlaştırdık.
namespace Core.DataAccess
{
    //generic constraint
    //class:referans tip
    //T değişkenimizi kısıtlamak için kullanırız.
    //T yerine sadece referans tip atayabilmek için. ve T sadece IEntity olanları alır.
    //IEntity olabilir  veya IEntity implemente edenler olabilir.
    //IEntity yapmazsak herhangi bir referans tip koyabiliriz. Bunu engellemek için kullandık.
    //new() : new'lenebilir olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
