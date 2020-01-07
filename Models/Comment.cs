using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogsApi.Models
{
    public class Comment
    {
        public int Cid     { get; set; }
        public int Uid     { get; set; }
        public string Cremark { get; set; }
        public DateTime Ctime   { get; set; }
        public int Iid { get; set; }
    }
}