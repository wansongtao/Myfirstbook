using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyFirstBook.Models;

namespace MyFirstBook.Controllers
{
    public class HomeController : Controller
    {
        #region 读取appsettings里的数据库连接字符串
        //private readonly string MyConnectionString;

        //public HomeController(IConfiguration configuration)
        //{
        //    MyConnectionString = configuration.GetSection("ConnectionStrings")["OracleConnectionString"];
        //}
        #endregion

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bookview()
        {
            return View();
        }

        /// <summary>
        /// 根据ID查询书籍信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetBook(int id)
        {
            var booklist = new BookController();
            var json = booklist.GetBookID(id);
            return json;
            //return Json(new { success = false, msg = "hello" });
        }

        public string Getbookall()
        {
            var allbooklist = new BookController();
            string json = allbooklist.GetBook();
            return json;
        }

        /// <summary>
        /// 修改书籍信息
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="BookName"></param>
        /// <param name="Author"></param>
        /// <param name="Price"></param>
        /// <param name="Publishing"></param>
        /// <returns></returns>
        public string PutBook(int ID, string BookName, string Author,
            string Price, string Publishing)
        {
            var updatebooklist = new BookController();
            string json = updatebooklist.UpdateBook(ID, BookName, Author, Price, Publishing);
            return json;
        }

        //添加书籍信息
        public string AddBookone(int ID, string BookName, string Author,
            string Price, string Publishing)
        {
            var addbooklist = new BookController();
            string json = addbooklist.AddBook(ID, BookName, Author, Price, Publishing);
            return json;
        }

        //删除书籍信息
        public string DeleteBookOne(int id)
        {
            var delbooklist = new BookController();
            string json = delbooklist.DeleteBook(id);
            return json;
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
