using Models.Records;

namespace Models.Students
{
    public class MasterStudent : Student
    {
        public MasterStudent(string uuid, RecordCollection records) : base(uuid, records)
        {
        }
    }
}
