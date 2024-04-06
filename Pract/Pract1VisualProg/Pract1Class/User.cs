using System;

namespace Pract1Class
{
    public class User
    {
        public int user_id;
        public int department_id;
        public string user_username;
        public string user_password;
        public string name;
        public UserRole user_role;
        public UserGender user_gender;
        public string user_email;

        public enum UserRole
        {
            PublicRelation,
            Division,
            Manager
        }
        public enum UserGender
        {
            Male,
            Female
        }
        public virtual void userLogin()
        {}
        public virtual void addProposal()
        { }
        public virtual void viewProposal()
        { }
        public virtual void confirmProposal()
        { }
        public virtual void createReports()
        { }
        public virtual void viewReports()
        { }
        public virtual void updateDepartament()
        { }
    }

    public class Login : User
    {
        public string username;
        public string password;
        public string LoginStatus()
        {}
    }

    public class Department : User
    {
        public int department_id;
        public string department_name;
        public override void UpdateDepartment()
        {}
        public void InsertDepartment()
        {}
        public void DeleteDepartment()
        {}
    }

    public class Report
}