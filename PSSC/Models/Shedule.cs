using System.Collections.Generic;

namespace Models
{
    public class Shedule
    {
        private string sheduleId;
        private List<CollegeClass> classes;

        public string SheduleId
        {
            get { return sheduleId; }
            set { sheduleId = value; }
        }

        public Shedule(string sheduleId)
        {
            this.sheduleId = sheduleId;
        }

        public Shedule(string sheduleId, List<CollegeClass> classes)
        {
            this.sheduleId = sheduleId;
            this.classes = classes;
        }

        public void AddCollegeClass(CollegeClass c)
        {
            classes.Add(c);
        }
    }
}
