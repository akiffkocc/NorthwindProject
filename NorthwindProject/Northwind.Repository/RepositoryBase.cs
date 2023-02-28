using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWind.ORM.Models;

namespace Northwind.Repository
{
    public class RepositoryBase<T> where T : class
    {
        private static NorthwindContext context;
        //singleton pattern
        public NorthwindContext Context
        {
            get 
            {
                if (context == null) 
                    context = new NorthwindContext();
                return context; 
            }
            set { context = value; }
        }

        public IList<T> Listele()
        {
            return Context.Set<T>().ToList();
        }
        public void Ekle(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            Context = new NorthwindContext();
        }
        public void Sil(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            Context = new NorthwindContext();
        }
        public void Guncelle()
        {
            Context.SaveChanges();
        }
    }
}
