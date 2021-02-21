using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingFacility.Models
{
    public class Student
    {
        // student first and middle names
        private string forenames { get; set; }

        // student lastname        
        private string surname { get; set; }
        
        // student E-mail address   
        private string email { get; set; }
   
        // student date of birth    
        private string dob { get; set; }
    
        // Degree student is enrolled for  
        private Degree degree;


        /*******
        /* Construter
        /**************/
        public Student(string forenames, string surname, string email, string dob)
        {
            this.forenames = forenames;
            this.surname = surname;
            this.email = email;
            this.dob = dob;
            this.degree = degree;
        }


       public string firstname
        {
            // returns students firstname from the forenames
            get { return forenames.Substring(0, forenames.IndexOf(" ") + 1); }
        }     
                
        public string fullnames
        {
            // returns students first, middle and last names
            get { return forenames + " " + surname; }
        }

    }
}
