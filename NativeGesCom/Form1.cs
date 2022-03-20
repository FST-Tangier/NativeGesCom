using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace NativeGesCom
{
    public partial class Form1 : Form
    {
        Commande cmd = new Commande();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            Article art = (Article) cmbArts.SelectedItem;
            int qte = int.Parse(txtQte.Text);
            Item item = new Item(art, qte);
            cmd.AddItem(item);
            grd.DataSource = null;
            grd.DataSource = cmd.Detail
                .Select(
                        i => 
                new {i.Art.Title, i.Art.Pu, i.Qte, i.Montant }).ToList();
            
            Text = "Prix Total :" + cmd.Price;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbArts.DisplayMember = "Title";
            cmbArts.DataSource = DB.GetArticles();

        }
    }
}
