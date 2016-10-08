namespace Models.Records
{
    public class CollegeRecord : Record
    {
        private int studyYear;
        private int? dormNumber;
        private Shedule shedule;
        private int creditCount;

        #region CollegeRecord getter / setter / new properties
        public int StudyYear
        {
            get { return studyYear; }
            set { studyYear = value; }
        }

        public int? DormNumber
        {
            get { return dormNumber; }
            set { dormNumber = value; }
        }

        public int CreditCount
        {
            get { return creditCount; }
            set { creditCount = value; }
        }

        public bool IsAssignedToDorm
        {
            get { return dormNumber != null; }
        }
        #endregion

        public CollegeRecord(string studentUUID, int studyYear, int? dormNumber, Shedule shedule, int creditCount) : base(studentUUID)
        {
            this.studyYear = studyYear;
            this.dormNumber = dormNumber;
            this.shedule = shedule;
            this.creditCount = creditCount;
        }
    }
}