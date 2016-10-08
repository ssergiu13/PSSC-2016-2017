using CollegeArchitecture.Records;

namespace CollegeArchitecture.Students
{
    public class MasterStudent : Student
    {
        public MasterStudent(string uuid, RecordCollection records) : base(uuid, records)
        {
        }
    }
}
