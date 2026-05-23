using System;

namespace UserNameSpace
{
    public class User
    {
        private string user_id;
        protected string user_password;

        public User(string id, string pass)
        {
            user_id = id;
            user_password = pass;
        }

        // Use string.Equals for case‑sensitive comparison
        public bool verifyLogin(string id, string pass)
        {
            return string.Equals(user_id, id, StringComparison.Ordinal) &&
                   string.Equals(user_password, pass, StringComparison.Ordinal);
        }

        // Virtual to allow polymorphism in Administrator
        public virtual void updatePassword(string newPassword)
        {
            if (!string.IsNullOrWhiteSpace(newPassword))
                user_password = newPassword;
        }

        public string getUserId() => user_id;
    }

    public class Administrator : User
    {
        private string admin_name;

        public Administrator(string name, string id, string pass) : base(id, pass)
        {
            admin_name = name;
        }

        // Override to demonstrate polymorphism
        public override void updatePassword(string newPassword)
        {
            base.updatePassword(newPassword);
        }

        public void updateAdminName(string newName)
        {
            if (!string.IsNullOrWhiteSpace(newName))
                admin_name = newName;
        }

        public string getAdminName() => admin_name;
    }
}