using HexGame.AspNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace HexGame.AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
         public ActionResult Index(User user)
        {
            int userID = user.UserID;
            string nickName = user.NickName;
            string email = user.Email;
            string avatar = user.Avatar;
            string _password = user._Password;
            return View();
        }
       
       
        public void Login(string email, string _password)
        {
            SqlConnection s = new SqlConnection(@"Data Source=HOME\SQLEXPRESS;Initial Catalog=LocalDB;Integrated Security=True");

            string query = "SELECT COUNT(1) FROM Users WHERE Email ='" + email + "' AND _Password ='" + _password + "'";
            SqlCommand sc = new SqlCommand(query, s);
            sc.CommandType = CommandType.Text;
            int count = Convert.ToInt32(sc.ExecuteScalar());
            
            
        }
        public List<string> RandomHexColors(int numColors)
        {
            
            var colors = new List<string>();
            var random = new Random();
            for (int i = 0; i < numColors; i++)
            {
                colors.Add(String.Format("#{0:X6}", random.Next(0x1000000)));
            }
            return colors;
        }
       
    }
}