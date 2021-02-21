using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingFacility.Models
{
    public class Degree
    {
 
        // degree name      
        private string name { get; set; }
  
        // duration of the degree     
        private int duration { get; set; }
     
        // list of courses that are part of this degree     
        private ArrayList<Course> courses;

        // Lecture responsible for this degree 
        private Lecture lecture;




        /*******
        /* Construter
        /**************/
        public Degree(string name, int duration, Lecture lecture)
        {
            this.name = name;
            this.duration = duration;

            courses = new ArrayList<Course>();
            this.degree =  degree;

           
        }
    }
}
