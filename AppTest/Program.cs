using System;
using System.Reflection;
using Autofac.Util;
using Business.Concrete;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace AppTest
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // CategoryManager categoryManager = new CategoryManager(new CategoryDal());
            //
            // Console.WriteLine(categoryManager.GetAll().Data.Count);

            
            
            Console.WriteLine(typeof(IEntityRepository<Post>).IsAssignableFrom(typeof(PostDal)));
        }
    }
}