namespace FunctionalProgramming.Students
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        private static int nextId = 1;

        private int facultyNumber;

        internal IList<int> marks;

        public Student(
            string fname, string lname, int age, int groupNumber) : this()
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Age = age;
            this.GroupNumber = groupNumber;
        }

        /// <summary>
        /// Internal constructor to be used by the generators
        /// </summary>
        internal Student()
        {
            this.facultyNumber = nextId++;
        }
        
        public string FirstName { get; internal set; }

        public string LastName { get; internal set; }

        public int Age { get; internal set; }

        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
        }

        public string Phone { get; set; }

        public IList<int> Marks
        {
            get
            {
                if (this.marks == null)
                {
                    return null;
                }
                else
                {
                    return this.marks.Take(this.marks.Count).ToArray();
                }
            }
        }

        public string Email { get; set; }

        public int GroupNumber { get; set; }

        public override string ToString()
        {
            int padding = 4;

            var strBuilder = new StringBuilder();

            strBuilder
                .AppendFormat("Student: {0}\n", this.FacultyNumber)
                .AppendFormat("Name: {0} {1}\n".PadLeft(padding), this.FirstName, this.LastName)
                .AppendFormat("Email: {0}".PadLeft(padding), this.Email);

            return strBuilder.ToString();
        }

        public void AddMark(int mark)
        {
            this.marks.Add(mark);
        }

        public void RemoveMark(int mark)
        {
            this.marks.Remove(mark);
        }
    }
}
