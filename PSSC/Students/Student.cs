using CollegeArchitecture.Records;

namespace CollegeArchitecture
{
    public abstract class Student
    {
        protected string uuid;
        protected RecordCollection records;

        public string UUID
        {
            get { return uuid; }
            set { uuid = value; }
        }

        public Student(string uuid, RecordCollection records)
        {
            this.uuid = uuid;
            this.records = records;
        }
    }
}