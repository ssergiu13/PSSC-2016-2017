using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Records
{
    public class RecordCollection
    {
        private PersonalRecord personalRecord;
        private MedicalRecord medicalRecord;
        private HighSchoolRecord highSchoolRecord;
        private ObservationRecord observationRecord;
        private CollegeRecord collegeRecord;

        public PersonalRecord PersonalRecord
        {
            get { return personalRecord; }
            set { personalRecord = value; }
        }

        public MedicalRecord MedicalRecord
        {
            get { return medicalRecord; }
            set { medicalRecord = value; }
        }

        public HighSchoolRecord HighSchoolRecord
        {
            get { return highSchoolRecord; }
            set { highSchoolRecord = value; }
        }

        public ObservationRecord ObservationRecord
        {
            get { return observationRecord; }
            set { observationRecord = value; }
        }

        public CollegeRecord CollegeRecord
        {
            get { return collegeRecord; }
            set { collegeRecord = value; }
        }

        public RecordCollection(PersonalRecord personalRecord, MedicalRecord medicalRecord, HighSchoolRecord highSchoolRecord, ObservationRecord observationRecord, CollegeRecord collegeRecord)
        {
            this.personalRecord = personalRecord;
            this.medicalRecord = medicalRecord;
            this.highSchoolRecord = highSchoolRecord;
            this.observationRecord = observationRecord;
            this.collegeRecord = collegeRecord;
        }
    }
}
