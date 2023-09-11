using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKING_WITH_STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IF THE SKY IS BLUE \n Then ROSES ARE RED\n WATER IS PURE\n I LOVE YOU");
            Console.WriteLine("Hy My Name Is \"Budha\"");
            Console.WriteLine("Hy My Name Is (Budha)");

            //declare
            string firstname = "Rantho";
            string lastname = "Budha";
            Console.WriteLine(firstname + " " + lastname);// + is used to concatinate

            //lengths
            Console.WriteLine("the length of the name is " + firstname.Length);//functions on strings
            //Change name to uppercase change name to lower case
            Console.WriteLine("Change" + firstname.ToUpper());
            Console.WriteLine("Change" + lastname.ToLower());

            //Contained words
            Console.WriteLine("FIRST NAME CONTAIN THE LETTER D " + firstname.Contains("D"));

            //Initials
            Console.WriteLine("the first letter of the "+ firstname[0]);
            Console.WriteLine("the index of r is " + firstname.IndexOf("r"));
            Console.WriteLine("the substring from 0-4 " + lastname.Substring(0,4));

            //read tis
            Console.ReadLine();
        }
    }
}
