namespace Models.Records
{
    public class CollegeRecord : Record
    {
        private int studyYear;
        private int? dormNumber;
        private int currentSheduleId;

        //TODO: Add grade related classes
        private int gradeSituationId;

        #region ObservationRecord getter / setter / new properties
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

        public int CurrentSheduleId
        {
            get { return currentSheduleId; }
            set { currentSheduleId = value; }
        }

        public bool IsAssignedToDorm
        {
            get { return dormNumber != null; }
        }
        #endregion

        public CollegeRecord(string studentUUID, int studyYear, int? dormNumber, int currentSheduleId) : base(studentUUID)
        {
            this.studyYear = studyYear;
            this.dormNumber = dormNumber;
            this.currentSheduleId = currentSheduleId;
        }
    }
}
