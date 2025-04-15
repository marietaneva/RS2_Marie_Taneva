using Microsoft.EntityFrameworkCore;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.EntityFrameworkCore.InMemory;
using NUnit.Framework;
using Microsoft.Extensions.Options;


namespace TestingLayer
{
    [TestFixture]
    public class TestManager
    {
        internal static ApplicationDbContext dbContext;

        static TestManager()
        {
            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase("inMemoryDb");
            dbContext = new ApplicationDbContext(builder.Options);
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            dbContext.Dispose();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
