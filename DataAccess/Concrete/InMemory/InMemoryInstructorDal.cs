using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InMemoryInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1, InstructorFirstName="Engin",InstructorLastName="Demiroğ",InstructorEmail="engindemirog@mail.com"},
                new Instructor{Id=2,InstructorFirstName="Halit Enes", InstructorLastName="Kalaycı", InstructorEmail="halitkalayci@mail.com"}
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor deleteToInstructor = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            _instructors.Remove(deleteToInstructor);
        }

        public void DeleteById(int id)
        {
            Instructor deleteToInstructor = _instructors.SingleOrDefault(i => i.Id == id);
            _instructors.Remove(deleteToInstructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors.ToList();
        }

        public void Update(Instructor instructor)
        {
            Instructor updateToInstructor = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            updateToInstructor.InstructorFirstName = instructor.InstructorFirstName;
            updateToInstructor.InstructorLastName = instructor.InstructorLastName;
            updateToInstructor.InstructorEmail = instructor.InstructorEmail;

        }
    }
}
