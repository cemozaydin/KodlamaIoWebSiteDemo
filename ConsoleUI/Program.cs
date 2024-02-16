using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            InstructorOperation instructorOperation = new InstructorOperation();
            CategoryOperation categoryOperation = new CategoryOperation();
            CourseOperation courseOperation = new CourseOperation();

            int select = 99;

            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("============  ANA MENU ============");
                Console.ResetColor();

                Console.WriteLine("1.  Eğitmen Listele");
                Console.WriteLine("2.  Eğitmen Ekle");
                Console.WriteLine("3.  Eğitmen Güncelle");
                Console.WriteLine("4.  Eğitmen Sil");
                Console.WriteLine();
                Console.WriteLine("\t5.  Kategori Listele");
                Console.WriteLine("\t6.  Kategori Ekle");
                Console.WriteLine("\t7.  Kategori Güncelle");
                Console.WriteLine("\t8.  Kategori Sil");
                Console.WriteLine();
                Console.WriteLine("\t\t9.  Kurs Listele");
                Console.WriteLine("\t\t10. Kurs Ekle");
                Console.WriteLine("\t\t11. Kurs Güncelle");
                Console.WriteLine("\t\t12. Kurs Sil");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("99 - ÇIKIŞ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("====================================\n");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write(">> Seçiminiz : ");
                Console.ResetColor();
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine();
                        instructorOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine();
                        instructorOperation.Add();
                        instructorOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine();
                        instructorOperation.GetAll();
                        instructorOperation.Update();
                        instructorOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        instructorOperation.DeleteById();
                        instructorOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine();
                        categoryOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine();
                        categoryOperation.Add();
                        categoryOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 7:
                        categoryOperation.GetAll();
                        categoryOperation.Update();
                        categoryOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.WriteLine();
                        categoryOperation.DeleteById();
                        categoryOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.WriteLine();
                        courseOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 10:
                        Console.WriteLine();
                        courseOperation.Add();
                        courseOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 11:
                        courseOperation.GetAll();
                        Console.WriteLine();
                        courseOperation.Upgrade();
                        Console.WriteLine();
                        courseOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 12:
                        courseOperation.DeleteById();
                        courseOperation.GetAll();
                        Console.WriteLine();
                        break;
                    case 99:
                    default:
                        break;


                }
                Console.Write("Ana Menüye dönmek için bir tuşa basınız...");
                Console.ReadLine();
                Console.Clear();
            } while (select != 99);
        }


    }
}
