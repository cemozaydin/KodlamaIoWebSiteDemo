using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course {Id=1, InstructorId=1, CourseName="C# + Angular", Description="Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)"},
                new Course {Id=2, InstructorId=1, CourseName="Javascript", Description="Yazılım Geliştirici Yetiştirici Kampı (Javascript)"},
                new Course {Id=3, InstructorId=1, CourseName="Java + React", Description="Yazılım Geliştirici Yetiştirici Kampı (Java + React)"},
                new Course {Id=4, InstructorId=1, CourseName=".Net", Description="Senior Yazılım Geliştirici Kampı (.Net)"}
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public void DeleteById(int id)
        {
            _courses.Remove(_courses.SingleOrDefault(c => c.Id == id));
        }

        public List<Course> GetAll()
        {
            return _courses.ToList();
        }

        public void Update(Course course)
        {
            Course updateCourse = _courses.SingleOrDefault(c => c.Id == course.Id);
            updateCourse.Id = course.Id;
            updateCourse.InstructorId = course.InstructorId;
            updateCourse.CourseName = course.CourseName;
            updateCourse.Description = course.Description;
        }
    }
}
