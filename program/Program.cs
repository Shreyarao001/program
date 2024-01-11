using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSchool
{
    class Program
    {
        static void Main()
        {

            schoolrepository repository = new schoolrepository();

            repository.AddStudent(new student { Name = "Shreya", ClassAndSection = "12A" });
            repository.AddStudent(new student { Name = "Sthairya", ClassAndSection = "10A" });

            repository.AddTeacher(new teacher { Name = "Mr.Tillu", ClassAndSection = "10A" });
            repository.AddTeacher(new teacher { Name = "Mrs.Radhika", ClassAndSection = "12A" });

            repository.AddSubject(new subject { Name = "MY-SQL", SubjectCode = "SQL101", Teacher = new teacher { Name = "Mr.Tillu", ClassAndSection = "10A" } });
            repository.AddSubject(new subject { Name = "Web Technology", SubjectCode = "WT101", Teacher = new teacher { Name = "Mrs.Radhika", ClassAndSection = "12A" } });

            DisplayStudentsInClass("12A");
            DisplaySubjectsTaughtByTeacher("Mrs.Radhika");

            Console.ReadLine();
        }

        static void DisplayStudentsInClass(string className)
        {
            var studentsInClass = schooldata.Instance.Students.Where(s => s.ClassAndSection == className);
            Console.WriteLine($"Students in {className}:");
            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }

        static void DisplaySubjectsTaughtByTeacher(string teacherName)
        {
            var subjectsByTeacher = schooldata.Instance.Subjects.Where(s => s.Teacher.Name.Equals(teacherName, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"Subjects taught by {teacherName}:");
            foreach (var subject in subjectsByTeacher)
            {
                Console.WriteLine($"- {subject.Name}");
            }
        }
    }

}