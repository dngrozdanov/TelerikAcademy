using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolOOP
{
    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Niki", "Zedoff", 6));
            students.Add(new Student("Danail", "Lipsyl", 4));
            students.Add(new Student("Viktor", "Kittan", 5));
            students.Add(new Student("Pesho", "Pushkin", 2));
            students.Add(new Student("Jack", "Reacher", 1));
            students.Add(new Student("Todor", "Petrov", 3));

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Niki", "Zedoff", 100, 6));
            workers.Add(new Worker("Danail", "Lipsyl", 200, 4));
            workers.Add(new Worker("Viktor", "Kittan", 50, 8));
            workers.Add(new Worker("Pesho", "Pushkin", 20, 14));
            workers.Add(new Worker("Jack", "Reacher", 25, 8));
            workers.Add(new Worker("Todor", "Petrov", 30, 4));

            var NewStudents = students.OrderBy(x => x.Grade).ToList();
            var NewWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();
            // TODO: Merge those 2 lists
        }
    }
}