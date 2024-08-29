using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class P_Students
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string first_lastname { get; set; }
        public string second_lastname { get; set; }
        public DateOnly birthdate { get; set; }
        public string gender { get; set; }
        public string email_contact { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string numControl {  get; set; }
    }
}
