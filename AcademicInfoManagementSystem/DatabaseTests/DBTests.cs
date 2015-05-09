using System;
using System.Collections.Generic;
using System.Linq;
using DatabaseEngine.DbContexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DatabaseEngine.Models;

namespace DatabaseTests
{
    [TestClass]
    public class DbTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            AppDbContext context = new AppDbContext();

            Assert.AreEqual(1, 1);

        }
        [TestMethod]
        public void TestStudent()
        {
            Student s = new Student(1, "Adela", "Berindean", "adbe01","1234");
            Assert.AreEqual(s.FirstName,"Adela");
        }
        [TestMethod]
        public void TestAddStudent()
        {
            AppDbContext context = new AppDbContext();
            var x = context.Students;
            Student s = new Student(1, "Adela", "Berindean", "adbe01","1234");
            context.Students.Add(s);
            context.SaveChanges();
            //List<Student> sl = context.Students.ToList();
           //Assert.Equals(true, true);
        }
    }
}
