using Models.Records;

namespace Models.Students
{
    public class BachelorStudent : Student
    {
        public BachelorStudent(string uuid, RecordCollection records) : base(uuid, records)
        {
        }
    }
}
