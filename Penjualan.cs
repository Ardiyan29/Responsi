using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        private string nota, tanggal, customer, jenis;
        private int totalNota;

        public int TotalNota
        {
            get { return totalNota; }
            set { totalNota = value; }
        }

        public string Nota
        {
            get { return nota; }
            set { nota = value; }
        }

        public string Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public Penjualan(string nota, string tanggal, string customer, string jenis, int total)
        {
            this.nota = nota;
            this.tanggal = tanggal;
            this.customer = customer;
            this.jenis = jenis == "T" ? "Tunai" : "Kredit";
            this.totalNota = total;
        }
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
    }
}
