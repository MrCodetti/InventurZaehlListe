using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventurZaehlListe
{
    public partial class Form1 : Form
    {
        private ArrayList listeEingabe;
        public Form1()
        {
            InitializeComponent();
            this.listeEingabe = new ArrayList();
        }

        private void btnHinzufugen_Click(object sender, EventArgs e)
        {
            Artikel artikel = new Artikel(this.txbArtBez.Text, this.txbLagerort.Text, 
                                          float.Parse(this.txbEinkauf.Text), int.Parse(this.txbIst.Text),
                                          int.Parse(this.txbSoll.Text));
            this.listeEingabe.Add(artikel);
            AnzeigeListe(this.listeEingabe);
            this.txbArtBez.Clear();
            this.txbLagerort.Clear();
            this.txbEinkauf.Clear();
            this.txbIst.Clear();
            this.txbSoll.Clear();
        }

        private void rdbRadiobuttons_CheckedChanged(object sender, EventArgs e)
        {
            AnzeigeListe(this.listeEingabe);
        }

        private void AnzeigeListe(ArrayList liste)
        {
            IComparer vergleich = new SortiereId();
            if (this.rdbBezeichnung.Checked)
            {
                vergleich = new SortiereBezeichnung();
            }
            if (this.rdbLagerort.Checked)
            {
                vergleich = new SortiereLagerort();
            }
            liste.Sort(vergleich);

            while (this.lstArtikel.Items.Count > 0)
            {
                this.lstArtikel.Items.RemoveAt(0);
            }

            foreach (Artikel artikel in liste)
            {
                ListViewItem item = new ListViewItem();
                item.Text = artikel.ArtikelId.ToString();
                item.SubItems.Add(artikel.ArtBezeichnung.ToString());
                item.SubItems.Add(artikel.Lagerort.ToString());
                item.SubItems.Add(artikel.Einkaufspreis.ToString());
                item.SubItems.Add(artikel.IstStand.ToString());
                item.SubItems.Add(artikel.SollStand.ToString());
                item.SubItems.Add(artikel.Inventurdifferenz.ToString());
                this.lstArtikel.Items.Add(item);
            }
        }
        public class SortiereId : IComparer
        {
            int IComparer.Compare(object links, object rechts)
            {
                return (((Artikel)links).ArtikelId - ((Artikel)rechts).ArtikelId);
            }
        }
        public class SortiereBezeichnung : IComparer
        {
            int IComparer.Compare(object links, object rechts)
            {
                return (String.Compare(((Artikel)links).ArtBezeichnung, ((Artikel)rechts).ArtBezeichnung));
            }
        }
        public class SortiereLagerort : IComparer
        {
            int IComparer.Compare(object links, object rechts)
            {
                return (String.Compare(((Artikel)links).Lagerort, ((Artikel)rechts).Lagerort));
            }
        }
    }
}
