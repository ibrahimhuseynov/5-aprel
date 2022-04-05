using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Library
    {
      public  List<Book> books;
      public List<Book> FilterByPrice(int min,int max)
        {
            var filters=books.FindAll(x=>x.Price>=min&&x.Price <=max);
            return filters; 
        }
        List<Genre> genres;
      public List<Genre> FilterByGenre(Genre name)
        {
            var filters1 = genres.FindAll(x => x.genre == x.name);
              return filters1;
        }
        public Book FİndBookByNo(int? _no)
        {
            if (_no == null)
            {
                return null; 
            }
            return books.Find(x=>x.No==_no);

        }
    }
}
