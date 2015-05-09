using System.Linq;
using DatabaseEngine.Models;

namespace BusinessLogic.Controllers
{
    public class Controller
    {
        #region Constructor & Instance
        private Controller()
        {

        }

        private static Controller instance;
        public static Controller Instance
        {
            get { return instance ?? (instance = new Controller()); }
        }

        #endregion

        #region Functionalities

        public bool AddGrade(Exam exam, Student student, int grade)
        {
            if (exam.StudentExamGrades.Count(seg => seg.Exam == exam && seg.Student == student) > 0)
                return false;
            var examGrade = new StudentExamGrade(student, grade, exam);
            student.GradesList.Add(examGrade);
            exam.StudentExamGrades.Add(examGrade);
            return true;
        }
        #endregion

        #region Fields
        #endregion
    }
}
