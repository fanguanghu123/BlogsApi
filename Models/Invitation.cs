using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsApi.Models
{
    public class Invitation
    {
        public int Iid     { get; set; }
        public string Ititle  { get; set; }
        public string Img     { get; set; }
        public string Iremark { get; set; }
        public DateTime Itime   { get; set; }
        public int Pv      { get; set; }
        public string Pstate  { get; set; }
        public int Uid { get; set; }
    }
}