using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{

    public enum GradeLevels
    {
        Freshman, Sophomore, Junior, Senior
    }
    internal class Student:Person
    {

        public GradeLevels GradeLevel { get; set; }
        public override float ComputeGradeAverage()
        {
            //will implement later
            return 0.0f;
        }
    }
}
