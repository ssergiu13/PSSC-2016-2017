using System.Collections.Generic;

namespace CollegeArchitecture.Records
{
    public class ObservationRecord : Record
    {
        private List<Observation> observations;
        private bool hasShownAggresiveBehaviour;
        private bool hasShownDepressiveBehaviour;

        #region ObservationRecord getter / setter
        public bool HasShownAggresiveBehaviour
        {
            get { return hasShownAggresiveBehaviour; }
            set { hasShownAggresiveBehaviour = value; }
        }

        public bool HasShownDepressiveBehaviour
        {
            get { return hasShownDepressiveBehaviour; }
            set { hasShownDepressiveBehaviour = value; }
        }
        #endregion

        public ObservationRecord(string studentUUID, bool hasShownAggresiveBehaviour, bool hasShownDepressiveBehaviour, List<Observation> observations) : base(studentUUID)
        {
            this.hasShownAggresiveBehaviour = hasShownAggresiveBehaviour;
            this.hasShownDepressiveBehaviour = hasShownDepressiveBehaviour;
            this.observations = observations;
        }
    }

    public class Observation
    {
        private string type;
        private string message;

        #region Observation getters / setters
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        #endregion

        public Observation(string type, string message)
        {
            this.type = type;
            this.message = message;
        }
    }
}
