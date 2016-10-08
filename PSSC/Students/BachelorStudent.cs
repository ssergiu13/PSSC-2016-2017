using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeArchitecture.Records;

namespace CollegeArchitecture.Students
{
    public class BachelorStudent : Student
    {
        public BachelorStudent(string uuid, RecordCollection records) : base(uuid, records)
        {
        }
    }
}
