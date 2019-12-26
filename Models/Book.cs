using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstBook.Models
{
    public class Book
    {
        /// <summary>
        /// id
        /// </summary>
        public int BookId { get; set; }

        /// <summary>
        /// 书名
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 出版社
        /// </summary>
        public string Publishing { get; set; }
    }
}
