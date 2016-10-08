namespace CollegeArchitecture.Records
{
    public class HighSchoolRecord : Record
    {
        private string highSchoolDossierRefId;
        private int finalHighSchoolAverage;
        private int finalExamAverage;

        #region HighSchoolRecord getters / setters
        public string HighSchoolDossierRefId
        {
            get { return highSchoolDossierRefId; }
            set { highSchoolDossierRefId = value; }
        }

        public int FinalHighSchoolAverage
        {
            get { return finalHighSchoolAverage; }
        }

        public int FinalExamAverage
        {
            get { return finalExamAverage; }
        }
        #endregion

        public HighSchoolRecord(string studentUUID, string highSchoolDossierRefId, int finalHighSchoolAverage, int finalExamAverage) : base(studentUUID)
        {
            this.highSchoolDossierRefId = highSchoolDossierRefId;
            this.finalHighSchoolAverage = finalHighSchoolAverage;
            this.finalExamAverage = finalExamAverage;
        }
    }
}
