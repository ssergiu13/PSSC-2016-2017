using Models.Students;
using System.Collections.Generic;

namespace Models.University
{
    public class Department
    {
        private string departmentId;
        private string name;
        private string mainRoom;
        private Teacher head;
        private List<Teacher> teachers;
        private List<Student> students;

        #region Department getters / setters
        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string MainRoom
        {
            get { return mainRoom; }
            set { mainRoom = value; }
        }
        #endregion

        public Department(string departmentId)
        {
            this.departmentId = departmentId;
        }

        public Department(string departmentId, string name, string mainRoom, Teacher head, List<Teacher> teachers, List<Student> students)
        {
            this.departmentId = departmentId;
            this.name = name;
            this.mainRoom = mainRoom;
            this.head = head;
            this.teachers = teachers;
            this.students = students;
        }
    }
}
