using System;
using System.Collections.Generic;
using System.Text;

namespace School_Library
{
    public class School
    {
        public string Name { get; set; }
       public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _TwiiterAddress;
        public string TwitterAddress
        {
            //make sure the twitter address starts with @
            get { return _TwiiterAddress;  }
            set
            {
                if(value.StartsWith("@"))
                {
                    _TwiiterAddress = value;
                } else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName,string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        
        public static int AverageThreeScores(int a, int b, int c)
        {
            
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.Append(this.City);
            sb.AppendLine(";");
            sb.AppendLine(State);
            sb.AppendLine("  ");
            sb.AppendLine(Zip);
            
            return sb.ToString();
        }
    }
}
