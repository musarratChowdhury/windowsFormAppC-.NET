using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }    
        public string Address { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber   { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            get { return _twitterAddress; }
            set {
                    if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }
        public static float AverageOFTHreeNUms(int a,int b,int c)
        {
            return (a + b + c) / 3;
        }
        public School()
        {
            Name = "Central HIGH";
            Address = "Dhaka";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(PhoneNumber);
            sb.AppendLine(Address);
            sb.Append(City);
            sb.Append(", ");
           
          
            sb.Append(Zip);
            return sb.ToString();
        }

    }
}
