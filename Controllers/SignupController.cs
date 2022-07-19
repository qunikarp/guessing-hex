using Microsoft.AspNetCore.Mvc;
using HexGame.AspNetCoreApp.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace HexGame.AspNetCoreApp.Controllers
{
    public class SignupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User user)
        {
            int userID = user.UserID;
            string nickName = user.NickName;
            string email = user.Email;
            string avatar = user.Avatar;
            string _password = user._Password;
            string connectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=LocalDB;Integrated Security=True";
            using (DatabaseContext db = new DatabaseContext(connectionString))
            {
                db.Add(new User { NickName = nickName, Email = email, _Password = _password});

            }
            return View();
           
        }
        public void Register(string email, string _password, string avatar, string nickName)
        {
            string connectionString = @"Data Source=HOME\SQLEXPRESS;Initial Catalog=LocalDB;Integrated Security=True";
            using (DatabaseContext db = new DatabaseContext(connectionString))
            {
                db.Add(new User {NickName=nickName, Email = email, _Password = _password, Avatar = avatar });

            }

        }
    }
}
