using System.Collections.Generic;

namespace Models.University
{
    public class University
    {
        private string universityId;
        private Address address;
        private Teacher rector;
        private List<Teacher> proRectors;
        private List<College> colleges;

        public string UniversityId
        {
            get { return universityId; }
            set { universityId = value; }
        }

        public string Address
        {
            get { return address.ToString(); }
        }

        public University(string universityId, Address address, Teacher rector, List<Teacher> proRectors, List<College> colleges)
        {
            this.universityId = universityId;
            this.address = address;
            this.rector = rector;
            this.proRectors = proRectors;
            this.colleges = colleges;
        }
    }
}
