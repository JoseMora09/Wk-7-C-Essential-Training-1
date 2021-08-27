using System;
using System.Collections.Generic;
using System.Text;

namespace School_Library
{
    public class Teacher : Person
    {
        public String Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            //ToDo fix implementation later
            return 0.0f;
        }
    }
}
