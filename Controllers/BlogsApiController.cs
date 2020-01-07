using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlogsApi.Models;
namespace BlogsApi.Controllers
{
    [RoutePrefix("Blogs")]
    public class BlogsApiController : ApiController
    {
        PublicToolsLib.HelpDb.DbHelper db=new PublicToolsLib.HelpDb.DbHelper();
        //普通用户登录
        [Route("Login")]
        public IHttpActionResult Login(string Uname,string Upwd)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Uname", Uname);
            pairs.Add("@Upwd", Upwd);
            return Json(db.Proc_GetTable("Login", pairs));
        }

        //显示所有学院
        [Route("SelCollege")]
        public IHttpActionResult SelCollege()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();           
            return Json(db.Proc_GetTable("SelCollege", pairs));
        }


        //注册
        [Route("Register")]
        public int Register(Users u)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Uname", u.Uname);
            pairs.Add("@Upwd", u.Upwd);
            pairs.Add("@Uimg", u.Uimg);
            pairs.Add("@Usex", u.Usex);
            pairs.Add("@Ustate", u.Ustate);
            pairs.Add("@Cid", u.Cid);
            return db.Proc_ExecuteNonQuery("Register", pairs);
        }

        //按学院分版块显示所有帖子(按时间排序)
        [Route("SelInvByCol")]
        public IHttpActionResult SelInvByCol(int Cid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Cid", Cid);
            return Json(db.Proc_GetTable("SelInvByCol", pairs));
        }

        //帖子详情
        [Route("SelInvitation")]
        public IHttpActionResult SelInvitation(int Iid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Iid", Iid);
            return Json(db.Proc_GetTable("SelInvitation", pairs));
        }

        //显示帖子下所有评论
        [Route("SelComment")]
        public IHttpActionResult SelComment(int Iid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Iid", Iid);
            return Json(db.Proc_GetTable("SelComment", pairs));
        }


        //发布评论
        [Route("InsertComment")]
        public int InsertComment(Comment c)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Uid",c.Uid);
            pairs.Add("@Cremark",c.Cremark);
            pairs.Add("@Ctime",c.Ctime);
            pairs.Add("@Iid",c.Iid);
            return db.Proc_ExecuteNonQuery("InsertComment", pairs);
        }

        //管理员登录
        [Route("LoginByMes")]
        public IHttpActionResult LoginByMes()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();           
            return Json(db.Proc_GetTable("LoginByMes", pairs));
        }

        //显示所有未审核帖子
        [Route("SelInvByState")]
        public IHttpActionResult SelInvByState()
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return Json(db.Proc_GetTable("SelInvByState", pairs));
        }

        //帖子通过
        [Route("UptInv")]
        public int UptInv(int Iid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Iid", Iid);
            return db.Proc_ExecuteNonQuery("UptInv", pairs);
        }

        //添加学院版块
        [Route("AddCollege")]
        public int AddCollege(string Cname)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Cname",Cname);
            return db.Proc_ExecuteNonQuery("AddCollege", pairs);
        }


        //删除学院版块
        [Route("DelCollege")]
        public int DelCollege(int Cid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Cid",Cid);
            return db.Proc_ExecuteNonQuery("DelCollege", pairs);
        }

        //显示/查询用户
        [Route("SelUser")]
        public IHttpActionResult SelUser(string Uname)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            pairs.Add("@Uname", Uname);
            return Json(db.Proc_GetTable("SelUser", pairs));
        }


        //禁用用户
        [Route("UptUser")]
        public int UptUser(int Cid)
        {
            Dictionary<string, object> pairs = new Dictionary<string, object>();
            return db.Proc_ExecuteNonQuery("UptUser", pairs);
        }
    }
}
