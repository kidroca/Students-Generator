namespace FunctionalProgramming
{
   using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students;
    using Students.Generators;

    class Example
    {
        static void Main()
        {
            var generator = new SimpleGenerator();

            IList<Student> students = generator.Genereate(10);

            Console.WriteLine("Working with this set of students:\n");

            foreach (var s in students)
            {
                Console.WriteLine(s);
                Console.WriteLine("Group: {0}\n", s.GroupNumber);
            }

            var textDocParser = new TextDocumentParser();

            IList<XcelStudent> xcelStudents = 
                textDocParser.Genereate(10, 10).Cast<XcelStudent>().ToList();

            foreach (var s in xcelStudents)
            {
                Console.WriteLine(s);
                Console.WriteLine("Type: {0}\n", s.StudentType);
            }

        }
    }
}
