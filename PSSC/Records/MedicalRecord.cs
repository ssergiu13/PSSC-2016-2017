namespace CollegeArchitecture.Records
{
    public class MedicalRecord : Record
    {
        private string medicalDossierRefId;
        private bool hasTransmitableSkinDisease;        //Pool and Library permission
        private bool requiresSpecialConditions;         //Wheelchair or special steps

        #region MedicalRecord getters / setters
        public string MedicalDossierRefId
        {
            get { return medicalDossierRefId; }
            set { medicalDossierRefId = value; }
        }

        public bool HasTransmitableSkinDisease
        {
            get { return hasTransmitableSkinDisease; }
            set { hasTransmitableSkinDisease = value; }
        }

        public bool RequiresSpecialConditions
        {
            get { return requiresSpecialConditions; }
            set { requiresSpecialConditions = value; }
        }
        #endregion

        public MedicalRecord(string studentUUID, string medicalDossierRefId, bool hasTransmitableSkinDisease, bool requiresSpecialConditions) : base(studentUUID)
        {
            this.medicalDossierRefId = medicalDossierRefId;
            this.hasTransmitableSkinDisease = hasTransmitableSkinDisease;
            this.requiresSpecialConditions = requiresSpecialConditions;
        }
    }
}
