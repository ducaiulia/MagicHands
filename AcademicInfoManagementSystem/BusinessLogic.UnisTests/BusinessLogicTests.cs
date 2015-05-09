using BusinessLogic.Controllers;
using DatabaseEngine.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogic.UnisTests
{
    [TestClass]
    public class BusinessLogicTests
    {
        [TestMethod]
        public void TestControllerGeneration()
        {
            Assert.AreEqual(Controller.Instance, Controller.Instance);
        }

        [TestMethod]
        public void TestAddGrade()
        {
            var course1 = new Course(1, "Math", new Semester(1, "Sem2"), null);
            var exam1 = new Exam(1, course1);
            course1.Exam = exam1;
            var student1 = new Student(1, "John", "Popescu", "jpai2312", "asdafs");

            Assert.AreEqual(student1.GradesList.Count, 0);
            Assert.AreEqual(exam1.StudentExamGrades.Count, 0);
            
            Controller.Instance.AddGrade(exam1, student1, 8);

            Assert.AreEqual(student1.GradesList.Count, 1);
            Assert.AreEqual(exam1.StudentExamGrades.Count, 1);
            Assert.AreEqual(exam1.StudentExamGrades[0], student1.GradesList[0]);
            Assert.AreEqual(student1.GradesList[0].Grade, 8);
        }
    }
}
