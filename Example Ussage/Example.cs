namespace FunctionalProgramming
{
    using System;
    using System.Collections.Generic;
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
        }
    }
}
