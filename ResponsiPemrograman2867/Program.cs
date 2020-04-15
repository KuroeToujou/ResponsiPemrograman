using System;
namespace ResponsiPemrograman2867
{
    public class Program
    {

        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan( 1 , 19112000, "dai", 500000);
            karyawan.gaji();

            Karyawan karyawan2 = new Karyawan(2, 19112001, "udin", 500000);
            karyawan2.gaji();

          
        }
    }
}

        