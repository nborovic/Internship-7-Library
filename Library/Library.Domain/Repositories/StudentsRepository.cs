﻿using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class StudentsRepository
    {
        private readonly LibraryContext _context;

        public StudentsRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Student studentToAdd)
        {
            _context.Students.Add(studentToAdd);

            _context.SaveChanges();
        }

        public void Remove(Student studentToRemove)
        {
            _context.Students.Remove(studentToRemove);

            _context.SaveChanges();
        }

        public void Edit(Student editedStudent)
        {
            var studentToEdit = _context.Students.FirstOrDefault(student => student.Id == editedStudent.Id);
            if (studentToEdit == null) return;

            studentToEdit.FirstName = editedStudent.FirstName;
            studentToEdit.LastName = editedStudent.LastName;
            studentToEdit.Birthdate = editedStudent.Birthdate;
            studentToEdit.Class = editedStudent.Class;
            studentToEdit.Gender = editedStudent.Gender;
            studentToEdit.Loans = editedStudent.Loans;

            _context.SaveChanges();
        }

        public Student Get(int id) => _context.Students.Find(id);
        public List<Student> GetAll() => _context.Students.ToList();
    }
}