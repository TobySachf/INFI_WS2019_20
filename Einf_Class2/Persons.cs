using System;

namespace Einf_Class2
{
    public class Persons
    {
        // Arrays, MemberVariable
        private string lastname, firstname;
        private DateTime brithday;

        /* Access mechanism
         * 
         * public ... Access from anywhere
         * private ... Access only inside the class
         * protected ... like private ... but a class above have rights 
         *
         */

        // Class has predefined constructors !!!

        /* Default-constructor
         *
         * ... initialize routine for the class
         * ... created from the system
         * ... can be overwritten by the user 
         *     --> standard constructor 
         */

        //standard-constructor ... initialize function for the class  
        public Persons()
        {
            lastname = "Brida";
            firstname = "Tobias";
            brithday = new DateTime(2003, 04, 16);
        }

        //overloaded-constructor 1 ... initialize function with params

        public Persons(string inLastname, string inFirstname)
        {
            lastname = inLastname;
            firstname = inFirstname;
        }
        
        //overloaded-constructor 2 ... initialize function with params

        public Persons(string inLastname, string inFirstname, DateTime inBirthday)
        {
            lastname = inLastname;
            firstname = inFirstname;
            brithday = inBirthday;
        }

        //Destructor ... called when function is deleted
        ~Persons()
        {
            //Free ram, ...
        }
        
        //Member-Function
        public TimeSpan CalcAge()
        {
            TimeSpan age = DateTime.Now - brithday;
            return age;
        }

        public void ChangeAge(DateTime inBirthday)
        {
            brithday = inBirthday;
        }

        public string RetrunPersons()
        {
            string outputString = lastname + firstname + brithday.ToString();
            return (outputString);
        }
    }
}