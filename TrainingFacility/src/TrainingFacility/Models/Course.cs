using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingFacility.Models
{
    public class Course
    {
      
        // course name      
        private string name { get; set; }

        // course duration in months
        private int duration { get; set; }
       
        // list of courses that are part of this degree     
        private ArrayList<Course> courses;
       
        // Degree the course is linked to to        
        private Degree degree;



        /*******
        /* Construter
        /**************/
        public Course(string name, int duration, Degree degree)
        {
            this.name = name;
            this.duration = duration;
            this.courses = new ArrayList<Course>()
            this.Degree = degree;
        }
    }
}
