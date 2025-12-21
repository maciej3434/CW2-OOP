using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Class
{
    internal class Admin: User
    {
        private DateOnly loginDate;

        public DateOnly LoginDate
        {
            get { return loginDate; }
            set { loginDate = value; }
        }
        public Admin (DateOnly loginDate, int userId, string userName, string password, string email, string role) : base(userId, userName, password, email, role)
        {
            this.loginDate = loginDate;
        }

        public Admin(int userId, string userName, string password, string email, string role) : base(userId, userName, password, email, role)
        {
        }

        public static Admin CreateSampleAdmin()
        {
            return new Admin(
                userId: 1,
                userName: "sampleAdmin",
                password: "Password123!",
                email: "Admin@example.com",
                role: "Admin"
            )
            {
                loginDate = DateOnly.FromDateTime(DateTime.Now)
            };
        }

    }
}
