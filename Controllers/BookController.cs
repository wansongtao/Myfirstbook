using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using MyFirstBook.Models;
using Newtonsoft.Json;

namespace MyFirstBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        #region 获取Startup.cs里的数据库连接字符串
        private readonly string MyConnectionString = Startup.MyConnectionString;
        #endregion

        #region 定义返回信息
        public int state;
        public string msg = "";  //具体信息
        public string json;
        #endregion

        // GET: api/Book
        [HttpGet]
        public string GetBook()  //查找数据库中所有书籍信息
        {
            try
            {
                string sql = "select BookId, BookName, Author, Price, Publishing from Book";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    var booklist = conn.Query<Book>(sql).ToList();

                    if(booklist.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(booklist);  //转化为json写法
                    }
                    else
                    {
                        state = 0;
                        msg = "未查找到数据";
                        json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                    }
                }
                return json;
            }
            catch(Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string GetBookID(int id)  //查询一条数据
        {
            try
            {
                string sql = "select BookId, BookName, Author, Price, Publishing from Book where BookId = :id";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    var bookonelist = conn.Query<Book>(sql, new { id }).ToList();

                    if(bookonelist.Count > 0)
                    {
                        json = JsonConvert.SerializeObject(bookonelist);
                    }
                    else
                    {
                        state = 0;
                        msg = "未查找到数据";
                        json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                    }
                }

                return json;
            }
            catch (Exception ex)
            {
                state = 0;
                msg = ex.Message;
                //json = Json(new { success = false, msg = ex.Message });
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
        }

        // POST: api/Book  添加一条书籍信息
        [HttpPost]
        public string AddBook(int ID, string BookName, string Author, string Price, string Publishing)
        {
            try
            {
                string sql = "insert into book (BookId, BookName, Author, Price, Publishing) " +
                    "values(:ID, :BookName, :Author, :Price, :Publishing)";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int addbooklist = conn.Execute(sql, new { ID, BookName, Author, Price, Publishing });

                    if(addbooklist > 0)
                    {
                        state = 1;
                        msg = "添加成功";
                    }
                    else
                    {
                        state = 0;
                        msg = "添加失败";
                    }
                }

                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
            catch(Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }            
        }

        // PUT: api/Book/5  根据ID修改书籍信息
        [HttpPut("{id}")]
        public string UpdateBook(int ID, string BookName, string Author, string Price, string Publishing)
        {
            try
            {
                string sql = "update book set BookName = :BookName, Author = :Author, " +
                    " Price = :Price, Publishing = :publishing where BookId = :ID";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int updatebook = conn.Execute(sql, new {
                        ID,
                        BookName,
                        Author,
                        Price,
                        Publishing
                    });

                    if(updatebook > 0)
                    {
                        state = 1;
                        msg = "修改成功";
                    }
                    else
                    {
                        state = 0;
                        msg = "修改失败";
                    }
                }
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
            catch(Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string DeleteBook(int id)  //根据ID删除一条数据
        {
            try
            {
                string sql = "delete from Book where BookId = :id";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int listone = conn.Execute(sql, new { id });

                    if(listone > 0)
                    {
                        state = 1;
                        msg = "删除成功";
                    }
                    else
                    {
                        state = 0;
                        msg = "删除失败";
                    }
                }
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
            catch(Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
        }


    }
}
