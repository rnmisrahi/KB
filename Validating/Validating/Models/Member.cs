using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Validating.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Remote("CheckName", "Home")]
        public string MemberName { get; set; }
        [Remote("CheckNickName", "Home", AdditionalFields ="Salary")]
        public string NickName { get; set; }
        public string Phone { get; set; }
        [Remote("CheckSalary", "Home")]
        public double Salary { get; set; }
    }
}