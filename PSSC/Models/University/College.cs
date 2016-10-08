using System.Collections.Generic;

namespace Models.University
{
    public class College
    {
        private string collegeId;
        private Address address;
        private Teacher dean;
        private List<Teacher> proDeans;
        private List<Department> departments;

        public string CollegeId
        {
            get { return collegeId; }
            set { collegeId = value; }
        }

        public string Address
        {
            get { return address.ToString(); }
        }

        public College(string collegeId, Address address, Teacher dean, List<Teacher> proDeans, List<Department> departments)
        {
            this.collegeId = collegeId;
            this.address = address;
            this.dean = dean;
            this.proDeans = proDeans;
            this.departments = departments;
        }
    }
}
