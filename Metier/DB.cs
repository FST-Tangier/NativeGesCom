using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class DB
    {
        public static List<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article(1, "Pain", 2),
                new Article(2, "Lait", 8),
                new Article(3, "Thé", 15),
                new Article(4, "Café", 20)
            };
        }
    }
}
