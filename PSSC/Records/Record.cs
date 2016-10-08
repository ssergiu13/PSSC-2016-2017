namespace CollegeArchitecture
{
    public abstract class Record
    {
        protected string studentUUID;

        public Record(string studentUUID)
        {
            this.studentUUID = studentUUID;
        }
    }
}
