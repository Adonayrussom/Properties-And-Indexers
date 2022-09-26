
using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Program demonstrating object initialisers and boolean propeties.
    /// </summary>
    public class StudentInitialiser
    {
        public string StudentID { get; set; }
        public string Name { get; set; }

        //public int MyProperty { get; private set; }//Read only propeties -> propg

        public DateTime AdmissionDate { get; set; }
        public string Course { get; set; }
        public bool IsFullTime { get; set; }

        public override String ToString()
        {
            return ($"\nStudent Details"
                    + "\n------------------------------"
                    + $"\nStudent ID: {this.StudentID}"
                    + $"\nStudent Names: {this.Name}"
                    + $"\nDate of Admission: {this.AdmissionDate} "
                    + $"\nCourse: {this.Course}"
                    + $"\nStudent is fulltime student: {this.IsFullTime}"
                    + "\n------------------------------\n");
        }

        static void Main(string[] args)
        {
            //Declare and initialise a StudentInitialiser object
            StudentInitialiser student = new StudentInitialiser
            {
                StudentID = "Student000001",
                Name = "Adonay Russom",
                AdmissionDate = DateTime.Now,
                Course = "ADSE",
                IsFullTime = true
            };

            //Display the students details
            Console.WriteLine(student.ToString());
        }

    }
}
