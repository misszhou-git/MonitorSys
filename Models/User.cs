﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQDESK.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Account { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserEmail { get; set; }
        public string Phone { get; set; }
    }
}
