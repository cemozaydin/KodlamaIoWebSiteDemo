using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void DeleteById(int id)
        {
            _courseDal.DeleteById(id);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll().ToList();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
