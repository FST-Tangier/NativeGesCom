using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    public class Commande
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Item> Detail { get; set; }
        public Commande()
        {
            Id = 1;
            Date = DateTime.Now;
            Detail = new List<Item>();

        }
        public void AddItem(Item item)
        {
            Detail.Add(item);
        }
        public int Price
        {
            get
            {
                return Detail.Sum(i => i.Montant);
            }

        }
    }
}
