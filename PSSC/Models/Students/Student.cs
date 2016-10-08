using Models.Records;

namespace Models.Students
{
    public abstract class Student
    {
        protected string uuid;
        private RecordCollection records;

        public string UUID
        {
            get { return uuid; }
            set { uuid = value; }
        }

        public RecordCollection Records
        {
            get { return records; }
            set { records = value; }
        }

        public Student(string uuid, RecordCollection records)
        {
            this.uuid = uuid;
            this.records = records;
        }
    }
}