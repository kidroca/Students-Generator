## Students Class And Students Generator 

### Generator For The Homework Assignment for Functional Programming

This library works with the text file *Students-data.txt* which is distributed with the homework, it can also work with other files if they are formatted in the same way

Add the Class Student\Student.cs project to your solution and add a reference to this project in the project you want to use it in.
The SampleGenerator need the path to the *Students-data.txt* if it can't find it by default (looking at "../../../") it will prompt you for the path to the file

---

### Sample Usage:

```C#
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
            var generator = new SimpleGenerator("../");

            IList<Student> students = generator.Genereate(10);

            Console.WriteLine("Working with this set of students:\n");

            foreach (var s in students)
            {
                Console.WriteLine(s);
                Console.WriteLine(s.GroupNumber);
            }
        }
    }
}
```

---

### Important Objects, Properties and Methods

* Student.cs -- The Student class 
    * Complies with the homework assgnment
    * The generator depends on this class

* SimpleGenerator.cs -- The base generator 
    * Can be extended through the virtual method *StudentParser*
    * Constructor takes 2 parameters which have default values so the constructor can be called with no arguments or it can be called with the path to the textfile default location is set to "../../../": 
    ```C#
    var generator = new SimpleGenerator();

    var generator = new SimpleGenerator(pathTo_Students-data.txt)
    ```

    * *Genereate* Method takes:
        * count - how many students to generate;
        * startLine - from which line to start parsing the text by default 1;

---

*You can test the functionality with the Example Project created in this solution*
*You are free to use and modify this project/library in your projects*

