using System;
using System.Collections.Generic;

/*
 * Notes:
 * - Tuple is usable starting with .NET 4 +
 */
namespace Models
{
    public enum ClassType { Course, Seminar, Laboratory, Project }
    public class CollegeClass
    {
        private string classId;
        private string teacherId;
        private string className;
        private ClassType type;
        private bool isWeekly;
        private int durationWeeks;

        //Tuesday - 8-9:30 - A101|A102
        List<Tuple<DayOfWeek, string, string>> classDays;

        #region CollegeClass getters / setters
        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        public string TeacherTitle
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }

        public ClassType Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool IsWeekly
        {
            get { return isWeekly; }
            set { isWeekly = value; }
        }

        public int DurationWeeks
        {
            get { return durationWeeks; }
            set { durationWeeks = value; }
        }
        #endregion

        public CollegeClass(string classId)
        {
            this.classId = classId;
        }

        public CollegeClass(string classId, string teacherId, string className, ClassType type, bool isWeekly, int durationWeeks, List<Tuple<DayOfWeek, string, string>> classDays)
        {
            this.classId = classId;
            this.teacherId = teacherId;
            this.className = className;
            this.type = type;
            this.isWeekly = isWeekly;
            this.durationWeeks = durationWeeks;
            this.classDays = classDays;
        }

        public void AddClassDay(Tuple<DayOfWeek, string, string> classMeta)
        {
            classDays.Add(classMeta);
        }
    }
}