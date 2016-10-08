using Models.Students;
using System;
using System.Collections.Generic;

namespace Models
{
    public interface ICommunicationChannel
    {
        void Connect();
        void Close();
    }

    public interface IDataContext
    {
        Student GetStudent();
        List<Student> GetStudents(string condition); //Func<Boolean> condition !?
        void ModifyStudent(int id);
        void AddStudent(Student student);
    }

    public abstract class StudentStorage : ICommunicationChannel, IDataContext
    {
        public abstract void Connect();
        public abstract void Close();

        public abstract Student GetStudent();
        public abstract List<Student> GetStudents(string condition);
        public abstract void ModifyStudent(int id);
        public abstract void AddStudent(Student student);
    }

    //SQL, No-SQL
    public abstract class DbStorage : StudentStorage
    {
        protected string connectionString;

        public DbStorage(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }

    //Possible Implementation of DbStorage
    public class SqlStorage : DbStorage
    {
        public SqlStorage(string connectionString) : base(connectionString) { }

        public override void Connect()
        {
            //TODO: Implement
        }

        public override void Close()
        {
            //TODO: Implement
        }

        public override Student GetStudent()
        {
            //TODO: Implement
            return null;
        }

        public override List<Student> GetStudents(string condition)
        {
            //TODO: Implement
            return null;
        }

        public override void ModifyStudent(int id)
        {
            //TODO: Implement
        }

        public override void AddStudent(Student student)
        {
            //TODO: Implement
        }
    }

    //Different REST APIs
    public abstract class ApiContext : IDataContext
    {
        protected Uri getUri;
        protected Uri putUri;
        protected Uri postUri;

        public ApiContext(Uri getUri, Uri putUri, Uri postUri)
        {
            this.getUri = getUri;
            this.putUri = putUri;
            this.postUri = postUri;
        }

        public abstract Student GetStudent();
        public abstract List<Student> GetStudents(string condition);
        public abstract void ModifyStudent(int id);
        public abstract void AddStudent(Student student);
    }

    //JSON, XML, Simple text
    public abstract class FileContext : IDataContext
    {
        protected string fileName;
        protected bool overwrite;

        public FileContext(string fileName, bool overwrite)
        {
            this.fileName = fileName;
            this.overwrite = overwrite;
        }

        public abstract Student GetStudent();
        public abstract List<Student> GetStudents(string condition);
        public abstract void ModifyStudent(int id);
        public abstract void AddStudent(Student student);
    }
}
