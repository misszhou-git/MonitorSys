using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QQDESK.Models;

namespace MonitorSys.Models
{
    public class  UserDB
    {
        public UserDB() {
            InitUser();
        }
        public List<User> users { get; set; }


        private void InitUser()
        {
            users = new List<User> ();
            //users.Add(new User() {});
        }
    }
}
