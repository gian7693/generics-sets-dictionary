using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Course.Entities;

namespace Course // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> turmaA = new HashSet<Student>();
            HashSet<Student> turmaB = new HashSet<Student>();
            HashSet<Student> turmaC = new HashSet<Student>();


            Console.Write("How many students for course A? ");
            int nA = int.Parse(Console.ReadLine());
            for (int i = 0; i < nA; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                Student aluno = new Student(cod);
                turmaA.Add(aluno);
            }
            Console.Write("How many students for course B? ");
            int nB = int.Parse(Console.ReadLine());
            for (int i = 0; i < nB; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                Student aluno = new Student(cod);
                turmaB.Add(aluno);
            }
            Console.Write("How many students for course C? ");
            int nC = int.Parse(Console.ReadLine());
            for (int i = 0; i < nC; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                Student aluno = new Student(cod);
                turmaC.Add(aluno);
            }

            HashSet<Student> total = new HashSet<Student>(turmaA);
            total.UnionWith(turmaB);
            total.UnionWith(turmaC);

            Console.WriteLine($"Total students: {total.Count}");
            PrintCollection(total);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
        }
    }
}