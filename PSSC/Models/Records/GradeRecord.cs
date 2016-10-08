using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Records
{
    public class GradeRecord : Record
    {
        List<Grade> grades;

        public GradeRecord(string studentUUID, List<Grade> grades) : base(studentUUID)
        {
            this.grades = grades;
        }

        public GradeRecord(string studentUUID) : base(studentUUID)
        {
            grades = null;
        }

        public List<Grade> Grades
        {
            get { return grades; }
            set { grades = value; }
        }
    }

    public class Grade
    {
        private string gradeEntryId;
        private string collegeClassId;
        private int gradeValue;
        private DateTime gradeDate;

        public Grade(string gradeEntryId)
        {
            this.gradeEntryId = gradeEntryId;
        }

        public Grade(string gradeEntryId, string collegeClassId, int gradeValue, DateTime gradeDate)
        {
            this.gradeEntryId = gradeEntryId;
            this.collegeClassId = collegeClassId;
            this.gradeValue = gradeValue;
            this.gradeDate = gradeDate;
        }

        public string GradeEntryId
        {
            get { return gradeEntryId; }
            set { gradeEntryId = value; }
        }

        public string GradeEntryId1
        {
            get { return gradeEntryId; }
            set { gradeEntryId = value; }
        }

        public string CollegeClassId
        {
            get { return collegeClassId; }
            set { collegeClassId = value; }
        }

        public DateTime GradeDate
        {
            get { return gradeDate; }
            set { gradeDate = value; }
        }
    }
}
