using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class InstructorOperation
    {
        InstructorManager _instructorManager = new InstructorManager(new InMemoryInstructorDal());

        int _id = 0;
        string _firstName, _lastName, _email = String.Empty;
        public void GetAll()
        {
            Console.WriteLine($"╔{new String('═', 68)}╗");
            Console.WriteLine(String.Format("║ {0,-3} | {1,-13} | {2,-18}| {3,-25}║", "Id","Eğitmen Adı","Eğitmen Soyadı","Email"));
            Console.WriteLine($"╚{new String('═', 68)}╝");

            foreach (var instructor in _instructorManager.GetAll())
            {
                Console.WriteLine(String.Format("║ {0,-3} | {1,-13} | {2,-18}| {3,-25}║", instructor.Id, instructor.InstructorFirstName, instructor.InstructorLastName, instructor.InstructorEmail));
            }
            Console.WriteLine($"╚{new String('═', 68)}╝");
        }

        public void DeleteById()
        {
            Console.Write("Silmek istediğiniz kayıt ID : ");
            _id = Int32.Parse(Console.ReadLine());
            _instructorManager.DeleteById(_id);            
        }

        public void Add()
        {
            Console.Write("Eğitmen ID giriniz     : ");
            _id = Int32.Parse(Console.ReadLine());
            Console.Write("Eğitmen Adı giriniz    : ");
            _firstName = Console.ReadLine();
            Console.Write("Eğitmen Soyadı giriniz : ");
            _lastName = Console.ReadLine();
            Console.Write("Eğitmen mail giriniz   : ");
            _email = Console.ReadLine();


            Instructor newInstuctor = new Instructor
            {
                Id = _id,
                InstructorFirstName = _firstName,
                InstructorLastName = _lastName,
                InstructorEmail = _email
            };

            _instructorManager.Add(newInstuctor);
            Console.WriteLine();
        }

        public void Update()
        {
            Console.Write("\nGüncellemek istediğiniz kayıt ID : ");
            _id = Int32.Parse(Console.ReadLine());

            Instructor result = _instructorManager.GetAll().Where(x => x.Id == _id).First();

            Console.Write("Eğitmen Adı giriniz    : ");
            _firstName = Console.ReadLine();
            Console.Write("Eğitmen Soyadı giriniz : ");
            _lastName = Console.ReadLine();
            Console.Write("Eğitmen mail giriniz   : ");
            _email = Console.ReadLine();

            result.Id = _id;
            result.InstructorFirstName = _firstName;
            result.InstructorLastName = _lastName;
            result.InstructorEmail = _email;

            _instructorManager.Update(result);

            Console.WriteLine();
        }

    }
}
