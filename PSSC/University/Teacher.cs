using CollegeArchitecture.Records;
using System.Collections.Generic;

namespace CollegeArchitecture.University
{
    public enum Titles { PhD, Engineer, Professor, AssistantProfessor, Instructor, AssociateInstructor }

    public class Teacher
    {
        private string teacherId;
        private string fullName;
        private string mainRoom;
        private Shedule shedule;
        private SortedSet<Titles> titles;

        #region Teacher getters / setters
        public string TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Titles
        {
            get {
                string concatenatedTitles = string.Empty;
            
                foreach(Titles t in titles)
                {
                    concatenatedTitles += t.ToString();
                }

                return concatenatedTitles;
            }
        }

        public string MainRoom
        {
            get { return mainRoom; }
            set { mainRoom = value; }
        }
        #endregion

        public Teacher(string teacherId)
        {
            this.teacherId = teacherId;
        }

        public Teacher(string teacherId, string fullName, Shedule shedule, SortedSet<Titles> titles)
        {
            this.teacherId = teacherId;
            this.fullName = fullName;
            this.shedule = shedule;
            this.titles = titles;
        }
    }
}
