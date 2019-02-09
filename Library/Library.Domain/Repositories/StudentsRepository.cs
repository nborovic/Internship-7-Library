using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class StudentsRepository
    {
        public static LibraryContext Context = new LibraryContext();

        public void Add(Student studentToAdd)
        {
            Context.Students.Add(studentToAdd);

            Context.SaveChanges();
        }

        public void Remove(Student studentToRemove)
        {
            Context.Students.Remove(studentToRemove);

            Context.SaveChanges();
        }

        public void Edit(Student editedStudent)
        {
            var studentToEdit = Context.Students.FirstOrDefault(student => student.Id == editedStudent.Id);
            if (studentToEdit == null) return;

            studentToEdit.FirstName = editedStudent.FirstName;
            studentToEdit.LastName = editedStudent.LastName;
            studentToEdit.Birthdate = editedStudent.Birthdate;
            studentToEdit.Class = editedStudent.Class;
            studentToEdit.Gender = studentToEdit.Gender;

            Context.SaveChanges();
        }

        public Student Get(int id) => Context.Students.Find(id);
        public List<Student> GetAll() => Context.Students.ToList();
    }
}