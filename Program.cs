using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            //set nilai properties
            saya.nim = "2286";
            saya.nama = "Ragil";
            saya.ipk = 4;

            kamu.nim = "9696";
            kamu.nama = "Alex";
            kamu.ipk = 4;
            

            //call method registrasi & isi KRS
            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();


        }

    }
}
