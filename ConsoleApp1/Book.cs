using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Genre
    {
       genre,
    };
    internal class Book
    {
       
        private int _no;
        public int  No { get; set; }  
        public string Name { get; set; }    
        public string AuthorName { get; set; }  
        public int Price { get; set; }  
        public Book()
        {
            _no++;
            No = _no;
        }
       
    }
}
