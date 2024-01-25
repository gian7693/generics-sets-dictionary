using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Student
    {
        public int Id { get; set; }
        
        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(Object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }

            Student other = obj as Student;
            return Id.Equals(other.Id);
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
