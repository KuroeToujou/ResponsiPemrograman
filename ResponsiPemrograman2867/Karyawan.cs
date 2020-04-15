using System;
using System.Reflection.Metadata.Ecma335;

namespace ResponsiPemrograman2867
{
    public class Karyawan
    {
        public int No { get; set; }
        public int NIK { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }

        public Karyawan(int no, int nik, string nama, int gaji)
        {
            Nama = Nama;
            NIK = nik;
            Gaji = gaji;
            No = no;
        }

        public void gaji()
        {
            Console.WriteLine("{0}no : {1} nik  : {2} gaji {3}", No, NIK, Nama, Gaji);
        }
        public void gajinaik()
        {
  
            Console.WriteLine("Karyawan has nama : {0} no : {1} nik : (2) gaji (3)", No, NIK, Nama, Gaji);
        }

    }
}