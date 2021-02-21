using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace TrainingFacility.Models
{
    public class Lecture
    {
        /******
        /* Members
        /************/

        // lecture first name       
        private string forenames { get; set; }
        
        // lecture lastname       
        private string surname { get; set; }
      
        /// lecture E-mail address       
        private string email { get; set; }
        
        // lecture date of birth     
        private string dob { get; set; }

       
        // list of degrees the lecture is responsible for       
        private ArrayList<Degree> degrees;

        /*******
        /* Construter
        /**************/
        public Lecture(string forenames, string surname, string email, string dob)
        {
            this.forenames = forenames;
            this.surname = surname;
            this.email = email;
            this.dob = dob;

            degrees =  new ArrayList<Degree>();

        }

        /*******
        /* Properties
        /**************/

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


        /******
        /* Functions
        /***********/

        

    }
}
