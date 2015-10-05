﻿namespace FunctionalProgramming.Students.Generators
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SimpleGenerator
    {
        private static Random random = new Random();

        private const int MinAge = 10;

        private const int MaxAge = 111;

        private const int MinGroup = 1;

        private const int MaxGroup = 11;

        private string dataFilePath;

        private string[] dataSplitPattern = { " ", "\t" };

        private string DataFilePath
        {
            set
            {
                if (File.Exists(value))
                {
                    this.dataFilePath = value;
                }
                else
                {
                    Console.WriteLine("Invlaid Path, try again: ");
                    this.DataFilePath = Console.ReadLine();
                }
                
            }
        }

        public SimpleGenerator(
            string txtFilePath = "../../../Students-data.txt", string[] splitPattern = null)
        {
            this.DataFilePath = txtFilePath;

            if (splitPattern != null)
            {
                this.dataSplitPattern = splitPattern;
            }
        }



        public IList<Student> Genereate(int count, int startLine = 1, IList<Student> list = null)
        {
            if (list == null)
            {
                list = new List<Student>();
            }

            using (var textReader = new StreamReader(this.dataFilePath))
            {
                // Skip to line
                for (int i = 0; i < startLine; i++)
                {
                    textReader.ReadLine();
                }
                
                string currentLine;
                while ((currentLine = textReader.ReadLine()) != null && count > 0)
                {
                    count--;

                    string[] data = currentLine.Split(
                        dataSplitPattern, StringSplitOptions.RemoveEmptyEntries);

                    Student current = this.StudentParser(data);
                    if (current != null)
                    {
                        list.Add(current);
                    }
                }
            }

            return list;
        }

        public virtual Student StudentParser(string[] textData)
        {
            // Don't touch it's magic
            if (textData.Length < 4)
            {
                return null;
            }
            else
            {
                var student = new Student()
                {
                    FirstName = textData[1],
                    LastName = textData[2],
                    Email = textData[3],
                    Age = random.Next(MinAge, MaxAge),
                    GroupNumber = random.Next(MinGroup, MaxGroup),
                    Phone = GeneratePhone(),
                    marks = GenerateMarks()
                };

                return student;
            }
        }

        private IList<int> GenerateMarks()
        {
            var marks = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int mark = random.Next(2, 7);
                marks.Add(mark);
            }

            return marks;
        }

        private string GeneratePhone()
        {
            var phone = new char[10];
            phone[0] = '+';

            for (int i = 1; i < phone.Length; i++)
            {
                phone[i] = Convert.ToChar(random.Next(0, 10));
            }

            return phone.ToString();
        }
    }
}
