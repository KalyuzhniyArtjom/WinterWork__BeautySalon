using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalonLib.Model
{
    public class Master
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string FullName { get; set; }
        public string Specialization { get; set; }
        public string SkillLevel { get; set; }
        public string Phone { get; set; }
    }
}
