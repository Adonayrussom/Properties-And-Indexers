using System;

namespace sess09_Properties__and_Indexers
{
    /// <summary>
    /// Program to demonstrate write-only property
    /// </summary>
    public class WriteOnlyProp
    {
        private string _password;

        public string Password
        {
            set
            {
                if (value == null || value == "")
                    _password = "Donny17";
                else
                    _password = value;
                //Rewrite the above code using the ternary operator
            }
        }
        public string Username { get; set; }

        public override string ToString()
        {
            return ($"User Details" +
                $"------------------------------" +
                $"\nUsername: {this.Username}" +
                $"\nPassword: {this._password}" +
                $"\n------------------------------");
        }

        static void Main(string[] args)
        {
            //Declare and instantiate a WriteOnly object/instance
            WriteOnlyProp user1 = new WriteOnlyProp();
            //Prompt the user for their credentials
            Console.WriteLine("Please enter your username -> ");
            user1.Username = Console.ReadLine();
            Console.WriteLine("Please enter your password -> ");
            user1.Password = Console.ReadLine();

            //Display the user's credentials
            Console.WriteLine(user1.ToString());
        }
    }
}
