using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Group
    {
        public double No;
        public Student[] Students;
        public int StudentLimit;

        public Student[] AddStudent(Student student)
        {
           Array.Resize(ref Students, (Students.Length + 1));
           Students[Students.Length - 1]= student;
            return Students;
        }
    }

}
