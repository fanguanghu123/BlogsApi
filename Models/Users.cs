using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsApi.Models
{
    public class Users
    {
        public int Uid    { get; set; }
        public string Uname  { get; set; }
        public string Upwd   { get; set; }
        public string Uimg   { get; set; }
        public string Usex   { get; set; }
        public string Ustate { get; set; }
        public int Cid { get; set; }
    }
}