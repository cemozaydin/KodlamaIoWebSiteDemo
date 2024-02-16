using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CourseOperation
    {
        CourseManager _courseManager = new CourseManager(new InMemoryCourseDal());

        int _id, _insructorId;
        string _courseName, _description;
        
        public void GetAll()
        {   
            Console.WriteLine($"╔{new String('═', 95)}╗");            
            Console.WriteLine(String.Format("║ {0,-3} ║ {1, -10} ║ {2, -13}║ {3, -60}║", "Id", "Eğitmen Id", "Kurs Adı", "Açıklama"));
            Console.WriteLine($"╚{new String('═', 95)}╝");

            foreach (var course in _courseManager.GetAll())
            {
                Console.WriteLine(String.Format("║ {0,-3} ║ {1, -10} ║ {2, -13}║ {3, -60}║", course.Id, course.InstructorId, course.CourseName, course.Description));
            }
            Console.WriteLine($"╚{new String('═', 95)}╝");
        }

        public void Add()
        {
            Console.Write("\nKurs Id : ");
            _id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Eğitmen Id : ");
            _insructorId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kurs Adı : ");
            _courseName = Console.ReadLine();

            Console.Write("Kurs Açıklaması : ");
            _description = Console.ReadLine();

            Course addCourse = new Course
            {
                Id = _id,
                InstructorId = _insructorId,
                CourseName = _courseName,
                Description = _description
            };

            _courseManager.Add(addCourse);
            
        }

        public void Upgrade()
        {
            Console.Write("\nGüncellemek istediğiniz <Kurs ID> : ");
            _id = Int32.Parse(Console.ReadLine());

            Course updateCourse = _courseManager.GetAll().Where(c=>c.Id == _id).FirstOrDefault();
            
            Console.Write("Eğitmen Id : ");
            _insructorId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kurs Adı : ");
            _courseName = Console.ReadLine();
            Console.Write("Kurs Açıklaması : ");
            _description = Console.ReadLine();

            updateCourse.Id = _id;
            updateCourse.InstructorId = _insructorId;
            updateCourse.CourseName = _courseName;
            updateCourse.Description = _description;
            
            _courseManager.Update(updateCourse);
            
        }

        public void Delete()
        {

        }

        public void DeleteById()
        {
            Console.Write("\nSilmek istediğiniz Kayıt ID : ");
            _id = Int32.Parse(Console.ReadLine());
            _courseManager.DeleteById(_id);
        }
    }
}
