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

        /// <summary>
        /// 0失败，1成功, 100查询数据成功（赋值给表格）
        /// </summary>
        public int state;

        /// <summary>
        /// 提示文本
        /// </summary>
        public string msg;

        /// <summary>
        /// 返回json格式字符串 
        /// </summary>
        public string json;

        #endregion

        // GET: api/Book
        [HttpGet]
        public string GetBook()  //查找数据库中所有书籍信息
        {
            try
            {
                string sql = "select BookId, BookName, Author, Price, Publishing from Book where Isdelete = :Isdelete";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    var booklist = conn.Query<Book>(sql, new { Isdelete = 0}).ToList();

                    if(booklist.Count > 0)
                    {
                        //int total = booklist.Count;
                        json = JsonConvert.SerializeObject(booklist);  //转化为json字符串写法
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

        [HttpGet]
        public string GetBookLayui(int page, int limit)  //查找数据库中所有书籍信息
        {
            try
            {
                string sql = null;

                string sqlone = "select * from Book where rownum <= :limit and Isdelete = :Isdelete ";
                string sqltwo = " and BookId not in (select BookId from Book where rownum <= :PageLimit and Isdelete = :Isdelete)";
                string allsql = "select Count(Isdelete) as BookId from Book where Isdelete = :Isdelete";

                using (OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int Records = 0;
                    var allbooklist = conn.Query<Book>(allsql, new { Isdelete = 0 }).ToList();

                    foreach(var item in allbooklist)
                    {
                        Records = item.BookId;  //数据总量（多少条数据）
                    }

                    if(Records > 0)
                    {
                        var booklist = allbooklist;

                        if (page > 1)
                        {
                            int PageLimit = (page - 1) * limit;
                            sql = sqlone + sqltwo;

                            booklist = conn.Query<Book>(sql, new { limit, Isdelete = 0, PageLimit }).ToList();
                        }
                        else if (page == 1)
                        {
                            sql = sqlone;

                            booklist = conn.Query<Book>(sql, new { limit, Isdelete = 0 }).ToList();
                        }
                        else
                        {
                            state = 0;
                            msg = "页码获取错误";
                            json = "{\"state\": "+ state + ", \"msg\": " + msg + ", \"count\": 0, \"data\": \"\"}";
                        }

                        if (booklist.Count > 0)
                        {
                            json = JsonConvert.SerializeObject(booklist);  //转化为json字符串写法
                            json = "{\"state\": 100, \"msg\": \"成功获取数据\", \"count\": " + Records + ", \"data\": " + json + "}";
                        }
                        else
                        {
                            state = 0;
                            msg = "分页失败";
                            json = "{\"state\": " + state + ", \"msg\": \"" + msg + "\", \"count\": 0, \"data\": [ ]}";
                        }
                    }
                    else
                    {
                        state = 0;
                        msg = "未查找到数据";
                        json = "{\"state\": "+ state +", \"msg\": \"" + msg + "\", \"count\": 0, \"data\": [ ]}";
                    }
                    
                }
                return json;
            }
            catch (Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\": " + state + ", \"msg\": \"" + msg + "\", \"count\": 0, \"data\": [ ]}";
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

                string cxsql = "select BookId from Book where BookId = :BookId";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    var booklist = conn.Query<Book>(cxsql, new { BookId = ID }).ToList();
                    if(booklist.Count > 0)
                    {
                        state = 0;
                        msg = "ID已存在";
                    }
                    else
                    {
                        int addbooklist = conn.Execute(sql, new { ID, BookName, Author, Price, Publishing });

                        if (addbooklist > 0)
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
        public string UpdateBook(int ID, string BookName, string Author, string Price, string Publishing, int updateid)
        {
            try
            {
                using (OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int updatebook = 0, errorstatus = 0;

                    if (updateid == 0)  //未修改ID
                    {
                        string sql = "update book set BookName = :BookName, Author = :Author, " +
                            " Price = :Price, Publishing = :publishing where BookId = :ID";

                        updatebook = conn.Execute(sql, new
                        {
                            ID,
                            BookName,
                            Author,
                            Price,
                            Publishing
                        });
                    }
                    else
                    {
                        string sqlone = "select BookId from Book where BookId = :ID";

                        var selectbook = conn.Query<Book>(sqlone, new { ID }).ToList();

                        if(selectbook.Count > 0)
                        {
                            errorstatus = 1;
                            msg = "ID已存在";
                        }
                        else
                        {
                            string sqltwo = "Update Book set BookId = :ID, BookName = :BookName, Author = :Author" +
                                " , Price = :Price, Publishing = :Publishing where BookId = :updateid";

                            updatebook = conn.Execute(sqltwo, new 
                            { ID, BookName, Author, Price, Publishing, updateid });
                        }
                    }

                    if (updatebook > 0)
                    {
                        state = 1;
                        msg = "修改成功";
                    }
                    else
                    {
                        state = 0;
                        if(errorstatus == 0)
                        {
                            msg = "修改失败";
                        }                       
                    }
                }
                json = "{\"state\":\"" + state + "\", \"msg\":\"" + msg + "\"}";
                return json;
            }
            catch (Exception ex)
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
                //string sql = "delete from Book where BookId = :id";
                string sql = "update book set Isdelete = :Isdelete where BookId = :id";

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    int listone = conn.Execute(sql, new { Isdelete = 1,id });

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

        //删除多条数据
        public string ManyDeleteBook(int[] NumberId)
        {
            try
            {
                string ID = null;
                int NumberIdLength = NumberId.Length;

                //获取删除数据的ID
                for (int i = 0; i < NumberId.Length; i++)
                {
                    if(i == 0)
                    {
                        ID = NumberId[i].ToString();
                    }
                    else if(i > 0)
                    {
                        ID += "," + NumberId[i];
                    }
                    
                }

                using(OracleConnection conn = new OracleConnection(MyConnectionString))
                {
                    string sql = "update Book set Isdelete = :Isdelete where BookId in("+ ID +")";

                    int deletebook = conn.Execute(sql, new { Isdelete = 1});

                    if(deletebook > 0)
                    {
                        state = 1;
                        msg = "删除成功";
                    }
                    else
                    {
                        state = 0;
                        msg = "删除失败";
                    }
                    json = "{\"state\": " + state + ",\"msg\":\"" + msg + "\", \"NumberIdLength\":"+ NumberIdLength + "}";
                }

                return json;
            }
            catch(Exception ex)
            {
                state = 0;
                msg = ex.Message;
                json = "{\"state\": " + state + ",\"msg\":\"" + msg + "\"}";
                return json;
            }
        }
    }
}
