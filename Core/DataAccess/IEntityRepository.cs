using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//Core katmani diger katmanlari referans almaz. Global katmandir.
//Eger referans alirsa bagimli olmus olur.
namespace Core.DataAccess
{
    //generic constraint - generic kisit

    //T yi kisitlamak istiyoruz.
    //T:class yaptigimizda T'nin referans tipte olmasi gerektigini belirtiyoruz.
    //T:class,IEntity yaptigimizda T'nin referans tipte olmasi gerektigini ve ek olarak,
    //IEntity olabilir veya IEntity'den turetilen (IEntity implamente eden) bir nesne olmasi gerektigini soyluyoruz.
    //new() yaptigimizda ise T'nin new'lenebilir olmasi gerektigini soyluyoruz. Interface new'lenemedigi icin IEntity soyut nesnesini de devreden cikartmis olduk.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Expression: filtreleme araci, delege.
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filter = null demek filtre vermek zorunda degilsin demek.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
