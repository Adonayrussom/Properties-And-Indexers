using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Class that will be used to create Person objects/instances using
    /// auto-implemented properties
    /// </summary>
    public class SimplerPerson
    {
        //Instance/object properties
        public string Names { get; set; }
        public DateTime BirthDate { get; set; }
        public char Gender { get; set; }
        public string Nationality { get; set; }



        public SimplerPerson()
        {

        }



        public SimplerPerson(string names, DateTime DOB, char gender, string nationality)
        {
            this.Names = names;
            this.BirthDate = DOB;
            this.Gender = gender;
            this.Nationality = nationality;
        }



        public override String ToString()
        {
            return ($"\nSimplePerson Details"
                    + "\n------------------------------"
                    + $"\nNames: {this.Names}"
                    + $"\nDate of Birth: {this.BirthDate:D}"
                    + $"\nGender: {(this.Gender == 'M' ? "Male" : "Female")} "
                    + $"\nNationality: {this.Nationality}"
                    + "\n------------------------------\n");
        }
    }



    public class DemoSimplerPerson
    {
        static void Main(string[] args)
        {
            //Declare a simpler person
            SimplerPerson myBuddy;
            //Prompt the user for myBuddy details



            Console.WriteLine($"Please enter your buddy's name -> ");
            string name = Console.ReadLine();



            Console.WriteLine($"Please enter your buddy's DOB -> ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());



            Console.WriteLine($"Please enter your buddy's gender -> ");
            char gender = char.Parse(Console.ReadLine());



            Console.WriteLine($"Please enter your buddy's nationality -> ");
            string nationality = Console.ReadLine();



            //Instantiate the myBuddy object
            myBuddy = new SimplerPerson(name, dob, gender, nationality);
            Console.WriteLine(myBuddy.ToString());
        }
    }
}
