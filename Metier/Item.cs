using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Item
    {
        public Article Art { get; set; }
        public int Qte { get; set; }
        public Item()
        {

        }

        public Item(Article art, int qte)
        {
            Art = art ?? throw new ArgumentNullException(nameof(art));
            Qte = qte;
        }
        public int Montant {
            get
            {
                return this.Art.Pu * this.Qte;
            }
                
        }
    }
}
