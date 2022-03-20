using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pu { get; set; }
        public Article()
        {

        }

        public Article(int id, string title, int pu)
        {
            Id = id;
            Title = title;
            Pu = pu;
        }
    }
}
