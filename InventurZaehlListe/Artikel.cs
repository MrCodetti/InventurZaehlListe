using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventurZaehlListe
{
    class Artikel
    {
        private static int idAutowert = 0;

        private int artikelId;
        private string artBezeichnung;
        private string lagerort;
        private float einkaufspreis;
        private int istStand;
        private int sollStand;
        private int inventurdifferenz;

        public Artikel(string artBezeichnung, string lagerort, float einkaufspreis,
                       int istStand, int sollStand)
        {
            this.artikelId = idAutowert;
            this.artBezeichnung = artBezeichnung;
            this.lagerort = lagerort;
            this.einkaufspreis = einkaufspreis;
            this.istStand = istStand;
            this.sollStand = sollStand;
            this.inventurdifferenz = sollStand - istStand;
            idAutowert++;
        }

        public int ArtikelId { get { return (this.artikelId); } }
        public string ArtBezeichnung { get { return (this.artBezeichnung); } }
        public string Lagerort { get { return (this.lagerort); } }
        public float Einkaufspreis { get { return (this.einkaufspreis); } }
        public int IstStand { get { return (this.istStand); } }
        public int SollStand { get { return (this.sollStand); } }
        public int Inventurdifferenz { get { return (this.inventurdifferenz); } }

        public override string ToString()
        {
            string text = String.Format("Artikel ID: {0}, " +
                                        "Artikel Bezeichnung: {1}, " +
                                        "Lagerort: {2}, " +
                                        "Einkaufspreis: {3}, " +
                                        "Ist-Stand: {4}, " +
                                        "Soll-Stand: {5}, " +
                                        "Inventurdifferenz: {6}",
                                        this.artikelId, this.artBezeichnung, this.lagerort,
                                        this.istStand, this.sollStand, this.inventurdifferenz);
            return (text);
        }
    }
}
